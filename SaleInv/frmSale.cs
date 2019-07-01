using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Microsoft.Reporting.WinForms;

namespace SaleInv
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private SqlCommand com;
        private decimal Total = 0;
        private Boolean b = false;
        private int cusID;

        private void frmSale_Load(object sender, EventArgs e)
        {
            myOper.myConnection();
            myOper.OnOff(this, false);
            txtSaleID.Text = "Auto Number";
            txtCusID.Text = "Auto Number";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                myOper.OnOff(this, true);
                myOper.ClearData(this);
                btnNew.Text = "Cancel";
                btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
                dtpSale.Focus();
                SendKeys.Send("%{DOWN}");
                myOper.FillCbo(cboCus, "cusID", "cusName", "tbCustomer");
                myOper.FillCbo(cboCate, "catID", "category", "tbCategory");
                myOper.FillCbo(cboPro, "proID", "proName", "tbProduct");
                lswSale.Clear();
                lswSale.View = View.Details;
                lswSale.Columns.Add("Product ID", 150);
                lswSale.Columns.Add("Product Name", 200);
                lswSale.Columns.Add("Quantity", 100);
                lswSale.Columns.Add("Unit Price", 150);
                lswSale.Columns.Add("Amount", 100);
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
                    lswSale.Items.Clear();
                    Total = 0;
                    btnNew.Text = "New";
                    btnNew.Image = SaleInv.Properties.Resources.Plus_25;
                }
            }
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

        private void btnNewCus_Click(object sender, EventArgs e)
        {
            if (btnNewCus.Text == "New Customer")
            {
                b = true;
                txtCusID.Text = "Auto Number";
                cboCus.Text = null;
                cboCus.Focus();
                btnNewCus.Text = "Old Customer";
                btnNewCus.Image = SaleInv.Properties.Resources.Cancel_25;
            }
            else
            {
                b = false;
                btnNewCus.Text = "New Customer";
                btnNewCus.Image = SaleInv.Properties.Resources.Plus_25;
            }
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("SELECT catID, sup FROM tbProduct WHERE proID='" + txtProID.Text + "'", myOper.con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cboCate.SelectedValue = int.Parse(dr[0].ToString());
                    cboPro.SelectedValue = txtProID.Text;
                    txtPrice.Text = string.Format("{0:c}", Decimal.Parse(dr[1].ToString()));
                    cboPro.Enabled = false;
                    txtQty.Text = "1";
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

        private void cboCus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cusID = int.Parse(cboCus.SelectedValue.ToString());
            com = new SqlCommand("SELECT cusID, cusContact FROM tbCustomer WHERE cusID=" + cusID, myOper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtCusID.Text = dr[0].ToString();
                txtCusCon.Text = dr[1].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void cboPro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProID.Text = cboPro.SelectedValue.ToString();
            txtProID.Enabled = false;
            txtQty.Text = "1";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Decimal amount, s;
            ListViewItem lv = lswSale.FindItemWithText(txtProID.Text);
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
                string[] arr = new string[5];
                arr[0] = txtProID.Text;
                arr[1] = cboPro.Text;
                arr[2] = txtQty.Text;
                s = decimal.Parse(txtPrice.Text, NumberStyles.Currency);
                arr[3] = string.Format("{0:c}", s);
                amount = decimal.Parse(txtQty.Text) * s;
                arr[4] = string.Format("{0:c}", amount);
                item = new ListViewItem(arr);
                lswSale.Items.Add(item);
                Total = Total + amount;
            }

            txtTotal.Text = string.Format("{0:c}", Total);
            txtProID.Text = null;
            cboPro.Text = null;
            cboPro.Enabled = true;
            txtQty.Text = null;
            txtPrice.Text = null;
            cboCate.Text = null;
            txtProID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("saleDate", typeof(DateTime));
            dtMaster.Columns.Add("empID", typeof(string));
            dtMaster.Columns.Add("empName", typeof(string));
            dtMaster.Columns.Add("cusID", typeof(int));
            dtMaster.Columns.Add("cusName", typeof(string));
            dtMaster.Columns.Add("cusCon", typeof(string));
            dtMaster.Columns.Add("sTotal", typeof(float));
            string saleDate = dtpSale.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (b == true)
                cusID = 0;
            string cn = cboCus.Text;
            string cc = txtCusCon.Text;
            dtMaster.Rows.Add(DateTime.Parse(saleDate), myOper.EmpID, myOper.EmpName, cusID, cn, cc, Total);

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("proID", typeof(string));
            dtDetail.Columns.Add("proName", typeof(string));
            dtDetail.Columns.Add("qty", typeof(int));
            dtDetail.Columns.Add("up", typeof(float));

            //Detail
            DataTable dtInvoice = new DataTable();
            dtInvoice.Columns.Add("proID", typeof(string));
            dtInvoice.Columns.Add("proName", typeof(string));
            dtInvoice.Columns.Add("qty", typeof(int));
            dtInvoice.Columns.Add("price", typeof(float));
            dtInvoice.Columns.Add("amount", typeof(float));

            foreach (ListViewItem item in lswSale.Items)
            {
                string pid = item.Text;
                string pn = item.SubItems[1].Text;
                int q = int.Parse(item.SubItems[2].Text);
                var un = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                dtDetail.Rows.Add(pid, pn, q, un);
                dtInvoice.Rows.Add(pid, pn, q, un, q * un);
            }

            com = new SqlCommand("InsertSale", myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter();
            par1.ParameterName = "@SM";
            par1.SqlDbType = SqlDbType.Structured;
            par1.Value = dtMaster;
            com.Parameters.Add(par1);
            SqlParameter par2 = new SqlParameter();
            par2.ParameterName = "@SD";
            par2.SqlDbType = SqlDbType.Structured;
            par2.Value = dtDetail;
            com.Parameters.Add(par2);

            com.Parameters.Add("@sid", SqlDbType.Int).Direction =
                        ParameterDirection.Output;
            com.Parameters.Add("@cid", SqlDbType.Int).Direction =
                        ParameterDirection.Output;
            com.ExecuteNonQuery();

            //Master
            var saleID = int.Parse(com.Parameters["@sid"].Value.ToString());

            if (b == true)
                cusID = int.Parse(com.Parameters["@cid"].Value.ToString());
            else
                cusID = int.Parse(txtCusID.Text);

            frmRptInvoice RptInvoice = new frmRptInvoice(); //1
            RptInvoice.Vinv.ProcessingMode = ProcessingMode.Local; //2
            LocalReport lRpt = RptInvoice.Vinv.LocalReport; //3
            lRpt.DisplayName = "rptInvoice.rdlc"; //4
            lRpt.DataSources.Clear(); //5
            ReportDataSource rds = new ReportDataSource("dsInvoice", dtInvoice);//6
            lRpt.DataSources.Add(rds);//7

            ReportParameter p1 = new ReportParameter("InvNo", string.Format("{0:000000}", saleID));//8
            lRpt.SetParameters(p1);

            ReportParameter p2 = new ReportParameter("InvDate", dtpSale.Value.ToString("dd-MM-yyyy HH:mm:ss"));//8
            lRpt.SetParameters(p2);

            ReportParameter p3 = new ReportParameter("EmpID", myOper.EmpID.ToString());//8
            lRpt.SetParameters(p3);

            ReportParameter p4 = new ReportParameter("CusID", cusID.ToString());//8
            lRpt.SetParameters(p4);

            ReportParameter p5 = new ReportParameter("CusName", cboCus.Text);//8
            lRpt.SetParameters(p5);

            ReportParameter p6 = new ReportParameter("Total", txtTotal.Text);//8
            lRpt.SetParameters(p6);

            RptInvoice.Show();
            RptInvoice.Vinv.RefreshReport();

            //MessageBox.Show(saleID.ToString());
            myOper.ClearData(this);
            lswSale.Items.Clear();
            btnNew.Text = "New";
            btnNew.Image = SaleInv.Properties.Resources.Plus_25;
            myOper.OnOff(this, false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult re;
            foreach (ListViewItem item in lswSale.Items)
            {
                if (item.Selected)
                {
                    re = MessageBox.Show("Do you want to remove this item?",
                        "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        ListViewItem it = lswSale.SelectedItems[0];
                        lswSale.Items.Remove(item);
                        var a = Decimal.Parse(it.SubItems[4].Text, NumberStyles.Currency);
                        Total = Total - a;
                        txtTotal.Text = string.Format("{0:c}", Total);
                    }
                }
            }
        }
    }
}