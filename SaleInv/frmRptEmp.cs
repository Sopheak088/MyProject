using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SaleInv
{
    public partial class frmRptEmp : Form
    {
        public frmRptEmp()
        {
            InitializeComponent();
        }

        private void frmRptEmp_Load(object sender, EventArgs e)
        {
            Vemp.SetDisplayMode(DisplayMode.PrintLayout);
            Vemp.ZoomMode = ZoomMode.Percent;
            Vemp.ZoomPercent = 100;
        }
    }
}