using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SaleInv
{
    public partial class frmRptEmpList : Form
    {
        public frmRptEmpList()
        {
            InitializeComponent();
        }

        private void frmRptEmpList_Load(object sender, EventArgs e)
        {
            VempList.SetDisplayMode(DisplayMode.PrintLayout);
            VempList.ZoomMode = ZoomMode.Percent;
            VempList.ZoomPercent = 100;
        }
    }
}