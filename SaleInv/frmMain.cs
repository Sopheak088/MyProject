using System;
using System.Windows.Forms;

namespace SaleInv
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = myOper.EmpName;
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("hh::mm::ss tt");
            if (myOper.EmpPos == "Admin" && myOper.EmpID != 0)
                return;
            else if (myOper.EmpPos == "seller")
            {
                btnImport.Enabled = false;
                btnImportReport.Enabled = false;
                btnEmployee.Enabled = false;
                btnSupplier.Enabled = false;
                btnProduct.Enabled = false;
                btnCategory.Enabled = false;
            }
            else if (myOper.EmpPos == "stockman")
            {
                btnEmployee.Enabled = false;
                btnCustomer.Enabled = false;
                btnSale.Enabled = false;
                btnSaleReport.Enabled = false;
            }
            else
            {
                btnImport.Enabled = false;
                btnImportReport.Enabled = false;
                btnSupplier.Enabled = false;
                btnProduct.Enabled = false;
                btnCustomer.Enabled = false;
                btnSale.Enabled = false;
                btnSaleReport.Enabled = false;
                btnCategory.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh::mm::ss tt");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCreateAccount acc = new frmCreateAccount();
            acc.ShowDialog();

            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin log = new frmLogin();
            log.ShowDialog();

            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEmployee emp = new frmEmployee();
            emp.ShowDialog();

            this.Close();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSale sale = new frmSale();
            sale.ShowDialog();

            this.Close();
        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSaleReport salerpt = new frmSaleReport();
            salerpt.ShowDialog();

            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmImport imp = new frmImport();
            imp.ShowDialog();

            this.Close();
        }

        private void btnImportReport_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmImportReport impre = new frmImportReport();
            impre.ShowDialog();

            this.Close();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSupplier sup = new frmSupplier();
            sup.ShowDialog();

            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCustomer cus = new frmCustomer();
            cus.ShowDialog();

            this.Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCategory cat = new frmCategory();
            cat.ShowDialog();

            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmProduct pro = new frmProduct();
            pro.ShowDialog();

            this.Close();
        }
    }
}