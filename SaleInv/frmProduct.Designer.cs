namespace SaleInv
{
    partial class frmProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUPIS = new System.Windows.Forms.TextBox();
            this.txtSUP = new System.Windows.Forms.TextBox();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Khmer OS Bokor", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(705, 77);
            this.label3.TabIndex = 22;
            this.label3.Text = "ព័ត៌មានអំពីទំនិញ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(150, 81);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(201, 36);
            this.txtProID.TabIndex = 23;
            this.txtProID.Tag = "*";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(150, 123);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(201, 36);
            this.txtProName.TabIndex = 24;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(150, 165);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(201, 36);
            this.txtQty.TabIndex = 25;
            this.txtQty.Tag = "*";
            // 
            // txtUPIS
            // 
            this.txtUPIS.Enabled = false;
            this.txtUPIS.Location = new System.Drawing.Point(150, 207);
            this.txtUPIS.Name = "txtUPIS";
            this.txtUPIS.Size = new System.Drawing.Size(201, 36);
            this.txtUPIS.TabIndex = 26;
            this.txtUPIS.Tag = "*";
            // 
            // txtSUP
            // 
            this.txtSUP.Location = new System.Drawing.Point(150, 249);
            this.txtSUP.Name = "txtSUP";
            this.txtSUP.Size = new System.Drawing.Size(201, 36);
            this.txtSUP.TabIndex = 27;
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(150, 291);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(201, 37);
            this.cboCate.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "លេខកូដទំនិញ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "ឈ្មោះទំនិញ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 36);
            this.label4.TabIndex = 31;
            this.label4.Text = "បរិមាណទំនិញ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "តំលៃនាំចូល";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 36);
            this.label6.TabIndex = 33;
            this.label6.Text = "តំលៃលក់ចេញ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 36);
            this.label7.TabIndex = 34;
            this.label7.Text = "ប្រភេទទំនិញ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = global::SaleInv.Properties.Resources.Save_25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(357, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::SaleInv.Properties.Resources.edit_25;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(357, 123);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 36);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = global::SaleInv.Properties.Resources.Close_25__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(357, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 36);
            this.btnClose.TabIndex = 37;
            this.btnClose.Tag = "*";
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 29;
            this.lstProduct.Location = new System.Drawing.Point(470, 123);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(220, 207);
            this.lstProduct.TabIndex = 38;
            this.lstProduct.Tag = "*";
            this.lstProduct.Click += new System.EventHandler(this.lstProduct_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(470, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 36);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.Tag = "*";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 339);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCate);
            this.Controls.Add(this.txtSUP);
            this.Controls.Add(this.txtUPIS);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUPIS;
        private System.Windows.Forms.TextBox txtSUP;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.TextBox txtSearch;
    }
}