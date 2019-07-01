namespace SaleInv
{
    partial class frmRptEmpList
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
            this.VempList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsEmployee = new SaleInv.dsEmployee();
            this.dtEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VempList
            // 
            this.VempList.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsEmpList";
            reportDataSource1.Value = this.dtEmployeeBindingSource;
            this.VempList.LocalReport.DataSources.Add(reportDataSource1);
            this.VempList.LocalReport.ReportEmbeddedResource = "SaleInv.rptEmpList.rdlc";
            this.VempList.Location = new System.Drawing.Point(0, 0);
            this.VempList.Name = "VempList";
            this.VempList.Size = new System.Drawing.Size(592, 451);
            this.VempList.TabIndex = 0;
            // 
            // dsEmployee
            // 
            this.dsEmployee.DataSetName = "dsEmployee";
            this.dsEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtEmployeeBindingSource
            // 
            this.dtEmployeeBindingSource.DataMember = "dtEmployee";
            this.dtEmployeeBindingSource.DataSource = this.dsEmployee;
            // 
            // frmRptEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 451);
            this.Controls.Add(this.VempList);
            this.Name = "frmRptEmpList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRptEmpList";
            this.Load += new System.EventHandler(this.frmRptEmpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dtEmployeeBindingSource;
        private dsEmployee dsEmployee;
        public Microsoft.Reporting.WinForms.ReportViewer VempList;
    }
}