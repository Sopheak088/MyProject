using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaleInv
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private SqlDataAdapter da;
        private DataTable dt;
        private SqlCommand com;
        private Boolean b;
        private string supID = "0";

        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM dbo.GetSupplier()", myOper.con);
            dt = new DataTable();
            da.Fill(dt);

            lswSup.Clear();
            lswSup.View = View.Details;

            lswSup.Columns.Add("ID", 60);
            lswSup.Columns.Add("Supplier", 200);
            lswSup.Columns.Add("Contact", 200);
            //Add item into listView
            string[] arr = new string[3];
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                arr[0] = row[0].ToString();
                arr[1] = row[1].ToString();
                arr[2] = row[2].ToString();
                item = new ListViewItem(arr);
                lswSup.Items.Add(item);
            }
            //Alternative color
            foreach (ListViewItem list in lswSup.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            myOper.OnOff(this, false);
            myOper.myConnection();
            txtSupID.Text = "Auto Number";
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                b = true;
                myOper.OnOff(this, true);
                myOper.ClearData(this);
                btnNew.Text = "Cancel";
                btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
                btnEdit.Enabled = false;
                txtSup.Focus();
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

        private void Modify(string X)
        {
            com = new SqlCommand(X, myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", int.Parse(supID.ToString()));
            com.Parameters.AddWithValue("@s", txtSup.Text);
            com.Parameters.AddWithValue("@c", txtSupCon.Text);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSup.Text.Trim()))
            {
                MessageBox.Show("Please input supplier...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSup.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSupCon.Text.Trim()))
            {
                MessageBox.Show("Please input contact...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupCon.Focus();
                return;
            }

            if (b == true)
            {
                Modify("InsertSupplier");
                MessageBox.Show("Your data was saved...", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Modify("UpdateSupplier");
                MessageBox.Show("Your data was updated...", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
            myOper.ClearData(this);
            myOper.OnOff(this, false);
            btnNew.Text = "New";
            btnNew.Image = SaleInv.Properties.Resources.Plus_25;
        }

        private void lswSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lswSup.SelectedItems.Count > 0)
            {
                ListViewItem item = lswSup.SelectedItems[0];
                supID = item.SubItems[0].Text;
                txtSup.Text = item.SubItems[1].Text;
                txtSupCon.Text = item.SubItems[2].Text;
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            btnNew.Text = "Cancel";
            btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
            myOper.OnOff(this, true);
            txtSup.Focus();
            btnEdit.Enabled = false;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("SearchSup", myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@s", txtSearch.Text);
            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);

            lswSup.Clear();
            lswSup.View = View.Details;

            lswSup.Columns.Add("ID", 60);
            lswSup.Columns.Add("Supplier", 200);
            lswSup.Columns.Add("Contact", 200);
            //Add item into listView
            string[] arr = new string[3];
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                arr[0] = row[0].ToString();
                arr[1] = row[1].ToString();
                arr[2] = row[2].ToString();
                item = new ListViewItem(arr);
                lswSup.Items.Add(item);
            }
            //Alternative color
            foreach (ListViewItem list in lswSup.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
        }
    }
}