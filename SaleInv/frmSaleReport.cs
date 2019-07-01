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
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace SaleInv
{
    public partial class frmSaleReport : Form
    {
        public frmSaleReport()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        DataTable dt;
        SqlCommand com;
        string eid = null;
        string cid = "0";
        DateTime dsa;
        DateTime dso;
        string cn="N/A";

        private void frmSaleReport_Load(object sender, EventArgs e)
        {
            myOper.OnOff(this, false);
            myOper.myConnection();
        }

        private void cboEmp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eid = cboEmp.SelectedValue.ToString();
            cboCus.Enabled = true;
            btnShow.Enabled = true;
            da = new SqlDataAdapter("SELECT DISTINCT cusID, cusName FROM tbSale WHERE empID='"
                                        + eid + "'", myOper.con);
            dt = new DataTable();
            da.Fill(dt);
            cboCus.DataSource = null;
            cboCus.Items.Clear();
            cboCus.Items.Clear();
            cboCus.DataSource = dt;
            cboCus.DisplayMember = "cusName";
            cboCus.ValueMember = "cusID";
            cboCus.Text = null;
            cid = "0";
        }

        private void cboCus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cid = cboCus.SelectedValue.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                da = new SqlDataAdapter("SELECT empID, empName FROM tbEmployee WHERE pos='Seller'", myOper.con);
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
                    lswSale.Items.Clear();
                    myOper.OnOff(this, false);
                    btnNew.Text = "New";
                    btnNew.Image = SaleInv.Properties.Resources.Plus_25;
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dsa = dtpStart.Value;
            dso = dtpStop.Value;
            lswSale.Clear();
            lswSale.View = View.Details;
            lswSale.Columns.Add("Sale ID", 100);
            lswSale.Columns.Add("Sale Date", 200);
            lswSale.Columns.Add("Cus Name", 200);
            lswSale.Columns.Add("Pro ID", 150);
            lswSale.Columns.Add("Pro Name", 200);
            lswSale.Columns.Add("Qty", 70);
            lswSale.Columns.Add("Price", 100);
            lswSale.Columns.Add("Amount", 100);
            if (dsa > dso)
            {
                MessageBox.Show("Invalid Date...");
                return;
            }
            else
            {
                com = new SqlCommand("SaleReport", myOper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@EI", eid);
                com.Parameters.AddWithValue("@CI", cid);
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
                    arr[0] = string.Format("{0:00000}", row[0].ToString()); //sale id
                    arr[1] = row[1].ToString(); //sale date
                    arr[2] = row[2].ToString(); //customer name
                    arr[3] = row[3].ToString(); //product id
                    arr[4] = row[4].ToString(); //product name
                    arr[5] = row[5].ToString(); //quantity
                    arr[6] = string.Format("{0:c}", decimal.Parse(row[6].ToString())); //price
                    arr[7] = string.Format("{0:c}", decimal.Parse(row[7].ToString()));//amount
                    item = new ListViewItem(arr);
                    lswSale.Items.Add(item);
                    btnPreview.Enabled = true;
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            frmRptSaleStatement rss = new frmRptSaleStatement();
            rss.Vsale.ProcessingMode = ProcessingMode.Local;
            LocalReport lRpt = rss.Vsale.LocalReport;
            lRpt.DisplayName = "rptSaleStatement.rdlc";
            lRpt.DataSources.Clear();

            DataTable dtss = new DataTable();
            dtss.Columns.Add("saleID", typeof(string));
            dtss.Columns.Add("saleDate", typeof(string));
            dtss.Columns.Add("cusName", typeof(string));
            dtss.Columns.Add("proID", typeof(string));
            dtss.Columns.Add("proName", typeof(string));
            dtss.Columns.Add("qty", typeof(string));
            dtss.Columns.Add("price", typeof(string));
            dtss.Columns.Add("amount", typeof(string));

            decimal t = 0;
            foreach (ListViewItem item in lswSale.Items)
            {
                string sid = item.Text;
                string sdate = string.Format("{0:dd-MM-yyyy}",item.SubItems[1].Text);
                string cus = item.SubItems[2].Text;
                string pid = item.SubItems[3].Text;
                string pn = item.SubItems[4].Text;
                string q =  item.SubItems[5].Text;
                string pr = item.SubItems[6].Text;
                string am = item.SubItems[7].Text;
                t = t + decimal.Parse(item.SubItems[7].Text, NumberStyles.Currency);
                dtss.Rows.Add(sid, sdate, cus, pid, pn, q, pr, am);
            }
            ReportDataSource rds = new ReportDataSource("dsSaleStatement", dtss);
            lRpt.DataSources.Add(rds);

            ReportParameter p1 = new ReportParameter("EmpID", eid);
            lRpt.SetParameters(p1);

            ReportParameter p2 = new ReportParameter("EmpName", cboEmp.Text);
            lRpt.SetParameters(p2);

            if (!string.IsNullOrEmpty(cboCus.Text.Trim()))
            {
                //MessageBox.Show("hello");
                ReportParameter p3 = new ReportParameter("CusName", cboCus.Text);
                lRpt.SetParameters(p3);
            }
            else
            {
                //MessageBox.Show("HI");
                ReportParameter p3 = new ReportParameter("CusName", cn);
                lRpt.SetParameters(p3);
            }
            ReportParameter p4 = new ReportParameter("begin", dtpStart.Value.ToString("dd-MM-yyyy"));
            lRpt.SetParameters(p4);

            ReportParameter p5 = new ReportParameter("end", dtpStop.Value.ToString("dd-MM-yyyy"));
            lRpt.SetParameters(p5);

            ReportParameter p6 = new ReportParameter("Total", string.Format("{0:c}", t.ToString()));
            lRpt.SetParameters(p6);

            rss.Show();
            rss.Vsale.RefreshReport();
        }
    }
}
