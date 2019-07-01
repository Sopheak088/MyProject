using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaleInv
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        DataTable dt;
        SqlCommand com;
        string cusID = "0";
        Boolean b;

        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM dbo.GetCustomer()", myOper.con);
            dt = new DataTable();
            da.Fill(dt);
            lswCus.Clear();
            lswCus.View = View.Details;

            lswCus.Columns.Add("ID", 60);
            lswCus.Columns.Add("Customer", 150);
            lswCus.Columns.Add("Contact", 150);
            //Load data from datatable into listview
            string[] arr = new string[3];
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                arr[0] = row[0].ToString();
                arr[1] = row[1].ToString();
                arr[2] = row[2].ToString();
                item = new ListViewItem(arr);
                lswCus.Items.Add(item);
            }
            //Atlernating row color
            foreach (ListViewItem list in lswCus.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtCusID.Text = "Auto Number";
            myOper.OnOff(this, false);
            myOper.myConnection();
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
                txtCusName.Focus();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            btnNew.Text = "Cancel";
            btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
            myOper.OnOff(this, true);
            txtCusName.Focus();
            btnEdit.Enabled = false;
        }

        private void lswCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lswCus.SelectedItems.Count > 0)
            {
                ListViewItem item = lswCus.SelectedItems[0];
                cusID = item.SubItems[0].Text;
                txtCusName.Text = item.SubItems[1].Text;
                txtCusCon.Text = item.SubItems[2].Text;
                btnEdit.Enabled = true;
            }
        }

        private void Modify(string X)
        {
            com = new SqlCommand(X, myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", int.Parse(cusID.ToString()));
            com.Parameters.AddWithValue("@n", txtCusName.Text);
            com.Parameters.AddWithValue("@c", txtCusCon.Text);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCusName.Text.Trim()))
            {
                MessageBox.Show("Please input customer...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCusCon.Text.Trim()))
            {
                MessageBox.Show("Please input contact...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusCon.Focus();
                return;
            }

            if (b == true)
            {
                Modify("InsertCustomer");
                MessageBox.Show("Your data was saved...", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Modify("UpdateCustomer");
                MessageBox.Show("Your data was updated...", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
            myOper.ClearData(this);
            myOper.OnOff(this, false);
            btnNew.Text = "New";
            btnNew.Image = SaleInv.Properties.Resources.Plus_25;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("SCusByName", myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", txtSearch.Text);
            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                com = new SqlCommand("SCusByCon", myOper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@n", txtSearch.Text);
                da = new SqlDataAdapter();
                da.SelectCommand = com;
                dt = new DataTable();
                da.Fill(dt);
            }

            lswCus.Clear();
            lswCus.View = View.Details;

            lswCus.Columns.Add("ID", 60);
            lswCus.Columns.Add("Customer", 200);
            lswCus.Columns.Add("Contact", 200);
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
                lswCus.Items.Add(item);
            }
            //Alternative color
            foreach (ListViewItem list in lswCus.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
        }
    }
}
