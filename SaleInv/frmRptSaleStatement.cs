using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SaleInv
{
    public partial class frmRptSaleStatement : Form
    {
        public frmRptSaleStatement()
        {
            InitializeComponent();
        }

        private void frmRptSaleStatement_Load(object sender, EventArgs e)
        {
            Vsale.SetDisplayMode(DisplayMode.PrintLayout);
            Vsale.ZoomMode = ZoomMode.Percent;
            Vsale.ZoomPercent = 100;
        }
    }
}
