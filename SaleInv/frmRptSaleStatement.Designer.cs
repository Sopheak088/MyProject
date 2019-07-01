namespace SaleInv
{
    partial class frmRptSaleStatement
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Vsale = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSaleStatement = new SaleInv.dsSaleStatement();
            this.dtSaleStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleStatement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleStatementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Vsale
            // 
            this.Vsale.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSaleStatement";
            reportDataSource1.Value = this.dtSaleStatementBindingSource;
            this.Vsale.LocalReport.DataSources.Add(reportDataSource1);
            this.Vsale.LocalReport.ReportEmbeddedResource = "SaleInv.rptSaleStatement.rdlc";
            this.Vsale.Location = new System.Drawing.Point(0, 0);
            this.Vsale.Name = "Vsale";
            this.Vsale.Size = new System.Drawing.Size(460, 381);
            this.Vsale.TabIndex = 0;
            // 
            // dsSaleStatement
            // 
            this.dsSaleStatement.DataSetName = "dsSaleStatement";
            this.dsSaleStatement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSaleStatementBindingSource
            // 
            this.dtSaleStatementBindingSource.DataMember = "dtSaleStatement";
            this.dtSaleStatementBindingSource.DataSource = this.dsSaleStatement;
            // 
            // frmRptSaleStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.Vsale);
            this.Name = "frmRptSaleStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRptSaleStatement";
            this.Load += new System.EventHandler(this.frmRptSaleStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleStatement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleStatementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dtSaleStatementBindingSource;
        private dsSaleStatement dsSaleStatement;
        public Microsoft.Reporting.WinForms.ReportViewer Vsale;
    }
}