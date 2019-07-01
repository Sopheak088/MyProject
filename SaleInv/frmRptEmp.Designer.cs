namespace SaleInv
{
    partial class frmRptEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vemp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Vemp
            // 
            this.Vemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vemp.LocalReport.ReportEmbeddedResource = "SaleInv.rptEmp.rdlc";
            this.Vemp.Location = new System.Drawing.Point(0, 0);
            this.Vemp.Name = "Vemp";
            this.Vemp.Size = new System.Drawing.Size(792, 571);
            this.Vemp.TabIndex = 0;
            // 
            // frmRptEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 571);
            this.Controls.Add(this.Vemp);
            this.Name = "frmRptEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRptEmp";
            this.Load += new System.EventHandler(this.frmRptEmp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer Vemp;

    }
}