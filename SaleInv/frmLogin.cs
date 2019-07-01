using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaleInv
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            myOper.myConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string un = txtUser.Text.Trim();
            string pw = txtPass.Text.Trim();

            SqlCommand com = new SqlCommand("UserLogin", myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@uid", un);
            com.Parameters.AddWithValue("@pwd", pw);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                myOper.EmpID = int.Parse(row[0].ToString());
                myOper.EmpName = row[1].ToString();
                myOper.EmpPos = row[4].ToString();

                this.Hide();

                frmMain ma = new frmMain();
                ma.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Your username and password incorrect...", "Incorrect",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                count++;
            }

            if (count == 3)
            {
                MessageBox.Show("You have logged in incorrect 3 times...",
                    "Bye Bye", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}