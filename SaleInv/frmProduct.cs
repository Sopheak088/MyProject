using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaleInv
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private SqlDataAdapter da;
        private DataTable dt;
        private SqlCommand com;

        private void FillList()
        {
            da = new SqlDataAdapter("SELECT proID, proName FROM tbProduct",
                myOper.con);
            dt = new DataTable();
            da.Fill(dt);
            lstProduct.DataSource = null;
            lstProduct.Items.Clear();
            lstProduct.DataSource = dt;
            lstProduct.DisplayMember = "proName";
            lstProduct.ValueMember = "proID";
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            myOper.myConnection();
            myOper.OnOff(this, false);
            myOper.FillCbo(cboCate, "catID", "category", "tbCategory");
            cboCate.Text = null;
            FillList();
        }

        private void lstProduct_Click(object sender, EventArgs e)
        {
            txtProID.Text = lstProduct.SelectedValue.ToString();
            txtProName.Text = lstProduct.Text;
            com = new SqlCommand("SELECT * FROM tbProduct WHERE proID='" +
                            txtProID.Text + "'", myOper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtQty.Text = dr[2].ToString();
                txtUPIS.Text = dr[3].ToString();
                txtSUP.Text = dr[4].ToString();
                cboCate.SelectedValue = int.Parse(dr[5].ToString());
            }
            dr.Dispose();
            com.Dispose();
            btnEdit.Enabled = true;
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
    }
}