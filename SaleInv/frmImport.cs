using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SaleInv
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        //SqlDataAdapter da;
        //DataTable dt;
        private SqlCommand com;

        private int supID;
        private decimal Total = 0;
        private Boolean b = false;

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                myOper.OnOff(this, true);
                myOper.ClearData(this);
                btnNew.Text = "Cancel";
                btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
                dtpImp.Focus();
                SendKeys.Send("%{DOWN}");
                myOper.FillCbo(cboSup, "supID", "supName", "tbSupplier");
                myOper.FillCbo(cboCate, "catID", "category", "tbCategory");
                myOper.FillCbo(cboPro, "proID", "proName", "tbProduct");
                lswImport.Clear();
                lswImport.View = View.Details;
                lswImport.Columns.Add("Product ID", 150);
                lswImport.Columns.Add("Product Name", 200);
                lswImport.Columns.Add("Quantity", 100);
                lswImport.Columns.Add("Unit Price", 150);
                lswImport.Columns.Add("Amount", 100);
                lswImport.Columns.Add("Category", 200);
                lswImport.Columns.Add("Category ID", 0);
                Total = 0;
            }
            else
            {
                DialogResult re = DialogResult.Yes;
                re = MessageBox.Show("Do you want to cancel?", "Cancel",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    myOper.ClearData(this);
                    myOper.OnOff(this, false);
                    lswImport.Items.Clear();
                    Total = 0;
                    btnNew.Text = "New";
                    btnNew.Image = SaleInv.Properties.Resources.Plus_25;
                }
            }
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            myOper.myConnection();
            myOper.OnOff(this, false);
            txtImpID.Text = "Auto Number";
            txtSupID.Text = "Auto Number";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult re = DialogResult.Yes;
            re = MessageBox.Show("Do you want to close?", "Close",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                this.Hide();

                frmMain ma = new frmMain();
                ma.ShowDialog();

                this.Close();
            }
        }

        private void cboSup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            supID = int.Parse(cboSup.SelectedValue.ToString());
            com = new SqlCommand("SELECT supID, supContact FROM tbSupplier WHERE supID=" + supID, myOper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtSupID.Text = dr[0].ToString();
                txtSupCon.Text = dr[1].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void cboPro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProID.Text = cboPro.SelectedValue.ToString();
            com = new SqlCommand("SELECT catID FROM tbProduct WHERE proID='" + txtProID.Text + "'", myOper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cboCate.SelectedValue = int.Parse(dr[0].ToString());
            }
            dr.Dispose();
            com.Dispose();
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("SELECT catID FROM tbProduct WHERE proID='" + txtProID.Text + "'", myOper.con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cboCate.SelectedValue = int.Parse(dr[0].ToString());
                    cboPro.SelectedValue = txtProID.Text;
                }
            }
            else
            {
                cboCate.Text = null;
                cboPro.Text = null;
            }

            dr.Dispose();
            com.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Decimal amount, s;

            ListViewItem lv = lswImport.FindItemWithText(txtProID.Text);
            if (lv != null)
            {
                var qty = int.Parse(lv.SubItems[2].Text) + int.Parse(txtQty.Text);
                lv.SubItems[2].Text = qty.ToString();
                Total = Total - decimal.Parse(lv.SubItems[4].Text, NumberStyles.Currency);
                var price = decimal.Parse(txtPrice.Text, NumberStyles.Currency);
                amount = qty * price;
                lv.SubItems[4].Text = string.Format("{0:c}", amount);
                Total = Total + amount;
            }
            else
            {
                ListViewItem item;
                string[] arr = new string[7];
                arr[0] = txtProID.Text;
                arr[1] = cboPro.Text;
                arr[2] = txtQty.Text;
                s = decimal.Parse(txtPrice.Text);
                arr[3] = string.Format("{0:c}", s);
                amount = decimal.Parse(txtQty.Text) * decimal.Parse(txtPrice.Text);
                arr[4] = string.Format("{0:c}", amount);
                arr[5] = cboCate.Text;
                arr[6] = cboCate.SelectedValue.ToString();
                item = new ListViewItem(arr);
                lswImport.Items.Add(item);
                Total = Total + amount;
            }

            txtTotal.Text = string.Format("{0:c}", Total);
            cboCate.Text = null;
            txtProID.Text = null;
            cboPro.Text = null;
            txtQty.Text = null;
            txtPrice.Text = null;
            txtProID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult re;
            foreach (ListViewItem item in lswImport.Items)
            {
                if (item.Selected)
                {
                    re = MessageBox.Show("Do you want to remove this item?",
                        "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        ListViewItem it = lswImport.SelectedItems[0];
                        lswImport.Items.Remove(item);
                        var a = Decimal.Parse(it.SubItems[4].Text, NumberStyles.Currency);
                        Total = Total - a;
                        txtTotal.Text = string.Format("{0:c}", Total);
                    }
                    //int idx = lswImport.FocusedItem.Index;
                    //MessageBox.Show(idx.ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("ImpDate", typeof(string));
            dtMaster.Columns.Add("supID", typeof(int));
            dtMaster.Columns.Add("supName", typeof(string));
            dtMaster.Columns.Add("supCon", typeof(string));
            dtMaster.Columns.Add("empID", typeof(string));
            dtMaster.Columns.Add("empName", typeof(string));
            dtMaster.Columns.Add("Amount", typeof(float));

            string impDate = dtpImp.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (b == true)
                supID = 0;

            string sn = cboSup.Text;  //get supplier name
            string sc = txtSupCon.Text; //get supplier contact

            dtMaster.Rows.Add(DateTime.Parse(impDate), supID, sn, sc, myOper.EmpID, myOper.EmpName, Total);

            //MessageBox.Show(impDate);
            //return;

            DataTable dtDetail = new DataTable();

            dtDetail.Columns.Add("proID", typeof(string));
            dtDetail.Columns.Add("proName", typeof(string));
            dtDetail.Columns.Add("qty", typeof(int));
            dtDetail.Columns.Add("upis", typeof(float));
            dtDetail.Columns.Add("catID", typeof(int));

            foreach (ListViewItem item in lswImport.Items)
            {
                string pid = item.Text; //get product id;
                string pn = item.SubItems[1].Text; //get product name
                int q = int.Parse(item.SubItems[2].Text);//get quantity
                var up = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency); //get unit price
                int ci = int.Parse(item.SubItems[6].Text); //get category
                dtDetail.Rows.Add(pid, pn, q, up, ci);
            }

            com = new SqlCommand("InsertImport", myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter();
            par1.ParameterName = "@IM";
            par1.SqlDbType = SqlDbType.Structured;
            par1.Value = dtMaster;
            com.Parameters.Add(par1);

            SqlParameter par2 = new SqlParameter();
            par2.ParameterName = "@ID";
            par2.SqlDbType = SqlDbType.Structured;
            par2.Value = dtDetail;
            com.Parameters.Add(par2);

            com.ExecuteNonQuery();
            MessageBox.Show("Your records was saved...", "Save",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            myOper.ClearData(this);
            lswImport.Items.Clear();
            myOper.OnOff(this, false);
            btnNew.Text = "New";
            btnNew.Image = SaleInv.Properties.Resources.Plus_25;
            myOper.OnOff(this, false);
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            if (btnNewSup.Text == "New Supplier")
            {
                b = true;
                txtSupID.Text = "Auto Number";
                cboSup.Text = null;
                cboSup.Focus();
                btnNewSup.Text = "Old Supplier";
                btnNewSup.Image = SaleInv.Properties.Resources.Cancel_25;
            }
            else
            {
                b = false;
                btnNewSup.Text = "New Supplier";
                btnNewSup.Image = SaleInv.Properties.Resources.Plus_25;
            }
        }
    }
}