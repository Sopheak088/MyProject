using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaleInv
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private SqlDataAdapter da;
        private DataTable dt;
        private Boolean b;
        private SqlCommand com;
        private string catID = "0";

        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM dbo.GetCategory()",
                                        myOper.con);
            dt = new DataTable();
            da.Fill(dt);
            lswCate.Clear();
            lswCate.View = View.Details;
            //Add Column Header
            lswCate.Columns.Add("ID", 54);
            lswCate.Columns.Add("Category", 190);
            //Load data from table into listview
            string[] arr = new string[2];
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                arr[0] = dr[0].ToString();
                arr[1] = dr[1].ToString();
                item = new ListViewItem(arr);
                lswCate.Items.Add(item);
            }
            //Alternative color
            foreach (ListViewItem list in lswCate.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }

            dt.Dispose();
            da.Dispose();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            myOper.OnOff(this, false);
            myOper.myConnection();
            txtCatID.Text = "Auto Number";
            LoadData();
        }

        private void lswCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lswCate.SelectedItems.Count > 0)
            {
                ListViewItem item = lswCate.SelectedItems[0]; //row
                catID = item.SubItems[0].Text; //column id
                txtCate.Text = item.SubItems[1].Text; //column category
                btnEdit.Enabled = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                b = true;
                myOper.OnOff(this, true);
                btnNew.Text = "Cancel";
                btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
                btnEdit.Enabled = false;
                txtCate.Focus();
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

        private void Modify(string X)
        {
            com = new SqlCommand(X, myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", int.Parse(catID.ToString()));
            com.Parameters.AddWithValue("@c", txtCate.Text);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCate.Text.Trim()))
            {
                MessageBox.Show("Please input category...", "Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCate.Focus();
                return;
            }
            if (b == true)
            {
                Modify("InsertCategory");
                MessageBox.Show("Your record was saved...", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Modify("UpdateCategory");
                MessageBox.Show("Your record was updated...", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
            myOper.ClearData(this);
            myOper.OnOff(this, false);
            btnNew.Text = "New";
            btnNew.Image = SaleInv.Properties.Resources.Plus_25;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            btnNew.Text = "Cancel";
            btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
            myOper.OnOff(this, true);
            txtCate.Focus();
            btnEdit.Enabled = false;
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

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("SCat", myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@c", txtSearch.Text);

            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            lswCate.Clear();
            lswCate.View = View.Details;
            lswCate.Columns.Add("ID", 54);
            lswCate.Columns.Add("Category", 190);

            string[] arr = new string[2];
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                arr[0] = row[0].ToString();
                arr[1] = row[1].ToString();

                item = new ListViewItem(arr);
                lswCate.Items.Add(item);
            }
            foreach (ListViewItem list in lswCate.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
        }
    }
}