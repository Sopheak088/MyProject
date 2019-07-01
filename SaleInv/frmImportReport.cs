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
    public partial class frmImportReport : Form
    {
        public frmImportReport()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        DataTable dt;
        SqlCommand com;
        string eid=null;
        string sid="0";
        DateTime dsa;
        DateTime dso;
        private void frmImportReport_Load(object sender, EventArgs e)
        {
            myOper.OnOff(this, false);
            myOper.myConnection();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                da = new SqlDataAdapter("SELECT empID, empName FROM tbEmployee WHERE pos='Stockman'", myOper.con);
                dt = new DataTable();
                da.Fill(dt);
                cboEmp.DataSource = null;
                cboEmp.Items.Clear();
                cboEmp.DataSource = dt;
                cboEmp.DisplayMember = "empName";
                cboEmp.ValueMember = "empID";
                cboEmp.Enabled = true;
                cboEmp.Text = null;
                myOper.ClearData(this);
                btnNew.Text = "Cancel";
                btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
                dtpStop.Value = dtpStart.Value;
            }
            else
            {
                DialogResult re = DialogResult.Yes;
                re = MessageBox.Show("Do you want to cancel?", "Cancel",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    myOper.ClearData(this);
                    lswImport.Items.Clear();
                    myOper.OnOff(this, false);
                    btnNew.Text = "New";
                    btnNew.Image = SaleInv.Properties.Resources.Plus_25;
                }
            }
        }

        private void cboEmp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eid = cboEmp.SelectedValue.ToString();
            cboSup.Enabled = true;
            btnShow.Enabled = true;
            da = new SqlDataAdapter("SELECT DISTINCT supID, supName FROM tbImport WHERE empID='" 
                                        + eid + "'", myOper.con);
            dt = new DataTable();
            da.Fill(dt);
            cboSup.DataSource = null;
            cboSup.Items.Clear();
            cboSup.DataSource = dt;
            cboSup.DisplayMember = "supName";
            cboSup.ValueMember = "supID";
            cboSup.Text = null;
            sid = "0";
        }

        private void cboSup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sid = cboSup.SelectedValue.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dsa = dtpStart.Value;
            dso = dtpStop.Value;
            lswImport.Clear();
            lswImport.View = View.Details;
            lswImport.Columns.Add("Imp ID", 100);
            lswImport.Columns.Add("Imp Date", 200);
            lswImport.Columns.Add("Sup Name", 200);
            lswImport.Columns.Add("Pro ID", 150);
            lswImport.Columns.Add("Pro Name", 200);
            lswImport.Columns.Add("Qty", 70);
            lswImport.Columns.Add("Price", 100);
            lswImport.Columns.Add("Amount", 100);
            if (dsa > dso)
            {
                MessageBox.Show("Invalid Date...");
                return;
            }
            else
            {
                com = new SqlCommand("ImportReport", myOper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@EI", eid);
                com.Parameters.AddWithValue("@SI", sid);
                com.Parameters.AddWithValue("@SA", dsa);
                com.Parameters.AddWithValue("@SO", dso);
                com.ExecuteNonQuery();
                da = new SqlDataAdapter();
                da.SelectCommand = com;
                dt = new DataTable();
                da.Fill(dt);
                string[] arr = new string[8];
                ListViewItem item;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    arr[0] = string.Format("{0:00000}", row[0].ToString()); //import id
                    arr[1] = row[1].ToString(); //import date
                    arr[2] = row[2].ToString(); //supplier name
                    arr[3] = row[3].ToString(); //product id
                    arr[4] = row[4].ToString(); //product name
                    arr[5] = row[5].ToString(); //quantity
                    arr[6] = string.Format("{0:c}", decimal.Parse(row[6].ToString())); //price
                    arr[7] = string.Format("{0:c}", decimal.Parse(row[7].ToString()));//amount
                    item = new ListViewItem(arr);
                    lswImport.Items.Add(item);

                }
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpStop.Value = dtpStart.Value;
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
