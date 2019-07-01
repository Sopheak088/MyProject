namespace SaleInv
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnImportReport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 637);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::SaleInv.Properties.Resources.user1;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 538);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(285, 93);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::SaleInv.Properties.Resources.account1;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(3, 439);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(285, 93);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account Setting";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Khmer OS Bokor", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(12, 297);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(276, 43);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = ".";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Khmer OS Bokor", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(12, 254);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(276, 43);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = ".";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Khmer OS Bokor", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(116, 211);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(24, 43);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = ".";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Bokor", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "អ្នកប្រើប្រាស់៖";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS Bokor", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 61);
            this.label3.TabIndex = 1;
            this.label3.Text = "ការនាំចូលនិងលក់ទំនិញ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Bokor", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(62, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "ប្រព័ន្ធគ្រប់គ្រង";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 139);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaleInv.Properties.Resources.images__6_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS Bokor", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(195, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 127);
            this.label1.TabIndex = 0;
            this.label1.Text = "ផ្សារទំនើបជីងហាប់";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnProduct);
            this.panel3.Controls.Add(this.btnCategory);
            this.panel3.Controls.Add(this.btnImportReport);
            this.panel3.Controls.Add(this.btnImport);
            this.panel3.Controls.Add(this.btnSaleReport);
            this.panel3.Controls.Add(this.btnSale);
            this.panel3.Controls.Add(this.btnCustomer);
            this.panel3.Controls.Add(this.btnSupplier);
            this.panel3.Controls.Add(this.btnEmployee);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(294, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 498);
            this.panel3.TabIndex = 2;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.White;
            this.btnProduct.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = global::SaleInv.Properties.Resources.images__5_;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduct.Location = new System.Drawing.Point(743, 236);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(239, 256);
            this.btnProduct.TabIndex = 16;
            this.btnProduct.Text = "មុខទំនិញ";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = global::SaleInv.Properties.Resources.images__3_;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategory.Location = new System.Drawing.Point(496, 236);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(239, 256);
            this.btnCategory.TabIndex = 15;
            this.btnCategory.Text = "ប្រភេទទំនិញ";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnImportReport
            // 
            this.btnImportReport.BackColor = System.Drawing.Color.White;
            this.btnImportReport.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportReport.Image = global::SaleInv.Properties.Resources.download1;
            this.btnImportReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportReport.Location = new System.Drawing.Point(790, 6);
            this.btnImportReport.Name = "btnImportReport";
            this.btnImportReport.Size = new System.Drawing.Size(190, 217);
            this.btnImportReport.TabIndex = 14;
            this.btnImportReport.Text = "របាយការណ៍នាំចូល";
            this.btnImportReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportReport.UseVisualStyleBackColor = false;
            this.btnImportReport.Click += new System.EventHandler(this.btnImportReport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Image = global::SaleInv.Properties.Resources.images44;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImport.Location = new System.Drawing.Point(594, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(190, 217);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "នាំចូលទំនិញ";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.BackColor = System.Drawing.Color.White;
            this.btnSaleReport.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReport.Image = global::SaleInv.Properties.Resources.download__2_;
            this.btnSaleReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaleReport.Location = new System.Drawing.Point(398, 6);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(190, 217);
            this.btnSaleReport.TabIndex = 12;
            this.btnSaleReport.Text = "របាយការណ៍លក់";
            this.btnSaleReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaleReport.UseVisualStyleBackColor = false;
            this.btnSaleReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.White;
            this.btnSale.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Image = global::SaleInv.Properties.Resources.images__1_;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSale.Location = new System.Drawing.Point(202, 6);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(190, 217);
            this.btnSale.TabIndex = 11;
            this.btnSale.Text = "លក់ទំនិញ";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = global::SaleInv.Properties.Resources._123;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.Location = new System.Drawing.Point(251, 236);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(239, 256);
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.Text = "ព័ត៌មានអតិថិជន";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.White;
            this.btnSupplier.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Image = global::SaleInv.Properties.Resources.aaa;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSupplier.Location = new System.Drawing.Point(6, 236);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(239, 256);
            this.btnSupplier.TabIndex = 9;
            this.btnSupplier.Text = "ព័ត៌មានប្រភពផ្គត់ផ្គង់";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.White;
            this.btnEmployee.Font = new System.Drawing.Font("Khmer OS Bokor", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = global::SaleInv.Properties.Resources.Customer;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployee.Location = new System.Drawing.Point(6, 6);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(190, 217);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.Text = "ព័ត៌មានបុគ្គលិក";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1279, 637);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Bokor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnSaleReport;
        private System.Windows.Forms.Button btnImportReport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}