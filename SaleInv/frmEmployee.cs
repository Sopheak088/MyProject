using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace SaleInv
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private string fp;
        private Boolean b;
        private SqlCommand com;
        private byte[] photo;
        private SqlDataAdapter da;
        private DataTable dt;
        private DialogResult re1;

        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM dbo.GetEmployee()", myOper.con);
            dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;
            dgvEmp.ColumnHeadersDefaultCellStyle.Font =
                new Font("Time News Roman", 14, FontStyle.Bold);
            dgvEmp.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvEmp.Columns["Name"].Width = 200; //define column width
            dgvEmp.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEmp.Columns["Hired Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEmp.Columns["Salary"].DefaultCellStyle.Format = "c";

            //define image size stretch
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvEmp.Columns["Photo"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (DataGridViewColumn col in dgvEmp.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvEmp.ClearSelection(); //clear select item in datagridview

            //dt.Dispose(); //close datatable
            //da.Dispose(); //close dataAdapter
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            myOper.myConnection();
            myOper.OnOff(this, false);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search ID or Name here...";
            LoadData();
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
                btnDelete.Enabled = false;
                txtID.Focus();
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

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpHire_ValueChanged(object sender, EventArgs e)
        {
            dtpHire.CustomFormat = "dd/MM/yyyy";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE| *.jpg; *.jpeg|PNG FILE|*.png|BMP FILE|*.bmp";
            fd.Title = "Open an image...";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picEmp.Image = Image.FromFile(fp);
            }
        }

        private void txtSal_Leave(object sender, EventArgs e)
        {
            myOper.ConStringtoCur(txtSal, sender, e);
        }

        private void txtSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            myOper.InputCur(txtSal, sender, e);
        }

        private void txtSal_Enter(object sender, EventArgs e)
        {
            myOper.ConCurtoNumber(txtSal, sender, e);
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (re1 == DialogResult.OK)
            {
                re1 = DialogResult.Cancel;
                return;
            }
            myOper.KeyControl(this, sender, e);
        }

        private void dtpDOB_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("%{DOWN}");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search ID or Name here...")
            {
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.ForeColor = Color.Gray;
                txtSearch.Text = "Search ID or Name here...";
            }
        }

        private void Modify(string X)
        {
            var salary = Decimal.Parse(txtSal.Text, NumberStyles.Currency);
            com = new SqlCommand(X, myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", txtID.Text);
            com.Parameters.AddWithValue("@n", txtName.Text);
            if (rdoF.Checked == true)
                com.Parameters.AddWithValue("@g", "F");
            else
                com.Parameters.AddWithValue("@g", "M");
            com.Parameters.AddWithValue("@d", dtpDOB.Value);
            com.Parameters.AddWithValue("@po", txtPos.Text);
            com.Parameters.AddWithValue("@s", salary);
            com.Parameters.AddWithValue("@a", txtAdd.Text);
            com.Parameters.AddWithValue("@c", txtContact.Text);
            com.Parameters.AddWithValue("@h", dtpHire.Value);
            if (fp != null)
                photo = File.ReadAllBytes(fp);
            com.Parameters.AddWithValue("@pt", photo);
            com.ExecuteNonQuery();//run stored procedure
            fp = null;
            myOper.ClearData(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                re1 = MessageBox.Show("Please input ID...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return; //stop running
            }

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                re1 = MessageBox.Show("Please input name...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return; //stop running
            }

            if (rdoF.Checked == false && rdoM.Checked == false)
            {
                re1 = MessageBox.Show("Please select gender...");
                rdoF.Focus();
                return;
            }

            if (dtpDOB.CustomFormat == " ")
            {
                re1 = MessageBox.Show("Please select birthdate...");
                dtpDOB.Focus();
                SendKeys.Send("%{DOWN}");
                return;
            }

            if (string.IsNullOrEmpty(txtPos.Text.Trim()))
            {
                re1 = MessageBox.Show("Please input position...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPos.Focus();
                return; //stop running
            }

            if (string.IsNullOrEmpty(txtSal.Text.Trim()))
            {
                re1 = MessageBox.Show("Please input salary...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSal.Focus();
                return; //stop running
            }

            if (string.IsNullOrEmpty(txtAdd.Text.Trim()))
            {
                re1 = MessageBox.Show("Please input address...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdd.Focus();
                return; //stop running
            }

            if (dtpHire.CustomFormat == " ")
            {
                re1 = MessageBox.Show("Please select birthdate...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpHire.Focus();
                SendKeys.Send("%{DOWN}");
                return;
            }

            if (string.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                re1 = MessageBox.Show("Please input contact number...", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return; //stop running
            }

            if (picEmp.Image == null)
            {
                re1 = MessageBox.Show("Please select an image...");
                btnBrowse_Click(sender, e);
            }

            if (b == true)
            {
                Modify("InsertEmployee");
                MessageBox.Show("Your data was saved...", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Modify("UpdateEmployee");
                MessageBox.Show("Your data was updated...", "Update",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //frmEmployee_Load(sender, e);
            myOper.OnOff(this, false);
            LoadData();
            btnNew.Text = "New";
            btnNew.Image = SaleInv.Properties.Resources.Plus_25;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            myOper.ConStrToTitle(txtName);
        }

        private void txtPos_Leave(object sender, EventArgs e)
        {
            myOper.ConStrToTitle(txtPos);
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvEmp.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                if (btnNew.Text == "Cancel" && btnSave.Enabled == true)
                    return;

                DataGridViewRow row = dgvEmp.Rows[i];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "ស")
                    rdoF.Checked = true;
                else
                    rdoM.Checked = true;
                dtpDOB.CustomFormat = "dd/MM/yyyy";
                dtpDOB.Text = row.Cells[3].Value.ToString();
                txtPos.Text = row.Cells[4].Value.ToString();
                txtSal.Text = string.Format("{0:c}", row.Cells[5].Value);
                txtAdd.Text = row.Cells[6].Value.ToString();
                txtContact.Text = row.Cells[7].Value.ToString();
                dtpHire.CustomFormat = "dd/MM/yyyy";
                dtpHire.Text = row.Cells[8].Value.ToString();

                //read byte form datagridview
                photo = (byte[])row.Cells[9].Value;
                MemoryStream ms = new MemoryStream(photo);
                picEmp.Image = Image.FromStream(ms);

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            btnNew.Text = "Cancel";
            btnNew.Image = SaleInv.Properties.Resources.Cancel_25;
            myOper.OnOff(this, true);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtID.Enabled = false;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do you want to delete?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Modify("DeleteEmployee");
                myOper.ClearData(this);
                frmEmployee_Load(sender, e);
                MessageBox.Show("Your record was deleted...", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("SEMPBYName", myOper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@s", txtSearch.Text);

            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;

            if (dt.Rows.Count < 1)
            {
                com = new SqlCommand("SEMPBYID", myOper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@s", txtSearch.Text);

                da = new SqlDataAdapter();
                da.SelectCommand = com;
                dt = new DataTable();
                da.Fill(dt);
                dgvEmp.DataSource = dt;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do you want to print list of staff?",
                "Print", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DataTable dtEmpList = new DataTable();
                dtEmpList.Columns.Add("empID", typeof(string));
                dtEmpList.Columns.Add("empName", typeof(string));
                dtEmpList.Columns.Add("empGen", typeof(string));
                dtEmpList.Columns.Add("empDob", typeof(DateTime));
                dtEmpList.Columns.Add("empPos", typeof(string));
                dtEmpList.Columns.Add("empSal", typeof(Decimal));
                dtEmpList.Columns.Add("empAdd", typeof(string));
                dtEmpList.Columns.Add("empCon", typeof(string));
                dtEmpList.Columns.Add("empHire", typeof(DateTime));
                dtEmpList.Columns.Add("empPhoto", typeof(byte[]));

                foreach (DataGridViewRow r in dgvEmp.Rows)
                {
                    dtEmpList.Rows.Add(r.Cells[0].Value, r.Cells[1].Value,
                                       r.Cells[2].Value, r.Cells[3].Value,
                                       r.Cells[4].Value, r.Cells[5].Value,
                                       r.Cells[6].Value, r.Cells[7].Value,
                                       r.Cells[8].Value, r.Cells[9].Value);
                }
                frmRptEmpList RptEmpList = new frmRptEmpList();
                RptEmpList.VempList.ProcessingMode = ProcessingMode.Local;
                LocalReport lRptList = RptEmpList.VempList.LocalReport;
                lRptList.DisplayName = "rptEmpList.rdlc";

                ReportDataSource rds = new ReportDataSource("dsEmpList", dtEmpList);
                lRptList.DataSources.Clear();
                lRptList.DataSources.Add(rds);

                RptEmpList.Show();
                RptEmpList.VempList.Refresh();
            }
            else if (re == DialogResult.No)
            {
                frmRptEmp RptEmp = new frmRptEmp();
                RptEmp.Vemp.ProcessingMode = ProcessingMode.Local;
                LocalReport lRpt = RptEmp.Vemp.LocalReport;
                lRpt.DisplayName = "rptEmp.rdlc";

                ReportParameter p1 = new ReportParameter("eid", txtID.Text);
                RptEmp.Vemp.LocalReport.SetParameters(p1);
                ReportParameter p2 = new ReportParameter("ename", txtName.Text);
                RptEmp.Vemp.LocalReport.SetParameters(p2);
                string gen;
                if (rdoF.Checked == true)
                    gen = "ស";
                else
                    gen = "ប";
                ReportParameter p3 = new ReportParameter("egen", gen);
                RptEmp.Vemp.LocalReport.SetParameters(p3);

                ReportParameter p4 = new ReportParameter("edob", dtpDOB.Value.ToString("dd-MM-yyyy"));
                RptEmp.Vemp.LocalReport.SetParameters(p4);

                ReportParameter p5 = new ReportParameter("epos", txtPos.Text);
                RptEmp.Vemp.LocalReport.SetParameters(p5);

                ReportParameter p6 = new ReportParameter("esal", txtSal.Text);
                RptEmp.Vemp.LocalReport.SetParameters(p6);

                ReportParameter p7 = new ReportParameter("ehire", dtpHire.Value.ToString("dd-MM-yyyy"));
                RptEmp.Vemp.LocalReport.SetParameters(p7);

                //ReportParameter p8 = new ReportParameter("image4", ConvertImgToBase64String());
                //RptEmp.Vemp.LocalReport.SetParameters(p8);
                RptEmp.Show();
                RptEmp.Vemp.RefreshReport();
            }
        }
    }
}