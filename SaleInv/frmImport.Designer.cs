namespace SaleInv
{
    partial class frmImport
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
            this.txtImpID = new System.Windows.Forms.TextBox();
            this.dtpImp = new System.Windows.Forms.DateTimePicker();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.cboSup = new System.Windows.Forms.ComboBox();
            this.txtSupCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPro = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNewSup = new System.Windows.Forms.Button();
            this.lswImport = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImpID
            // 
            this.txtImpID.Enabled = false;
            this.txtImpID.Location = new System.Drawing.Point(237, 85);
            this.txtImpID.Name = "txtImpID";
            this.txtImpID.Size = new System.Drawing.Size(204, 36);
            this.txtImpID.TabIndex = 0;
            this.txtImpID.Tag = "*";
            // 
            // dtpImp
            // 
            this.dtpImp.CustomFormat = "dd/MM/yyyy";
            this.dtpImp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImp.Location = new System.Drawing.Point(237, 127);
            this.dtpImp.Name = "dtpImp";
            this.dtpImp.Size = new System.Drawing.Size(204, 36);
            this.dtpImp.TabIndex = 1;
            this.dtpImp.Tag = "*";
            // 
            // txtSupID
            // 
            this.txtSupID.Enabled = false;
            this.txtSupID.Location = new System.Drawing.Point(237, 169);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(204, 36);
            this.txtSupID.TabIndex = 2;
            this.txtSupID.Tag = "*";
            // 
            // cboSup
            // 
            this.cboSup.FormattingEnabled = true;
            this.cboSup.Location = new System.Drawing.Point(237, 211);
            this.cboSup.Name = "cboSup";
            this.cboSup.Size = new System.Drawing.Size(204, 37);
            this.cboSup.TabIndex = 3;
            this.cboSup.SelectionChangeCommitted += new System.EventHandler(this.cboSup_SelectionChangeCommitted);
            // 
            // txtSupCon
            // 
            this.txtSupCon.Location = new System.Drawing.Point(596, 86);
            this.txtSupCon.Multiline = true;
            this.txtSupCon.Name = "txtSupCon";
            this.txtSupCon.Size = new System.Drawing.Size(204, 78);
            this.txtSupCon.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "លេខសម្គាល់ការនាំចូល";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "កាលបរិច្ឆេទនាំចូល";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "លេខសម្គាល់ប្រភពផ្គត់ផ្គង់";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "ឈ្មោះប្រភពផ្គត់ផ្គង់";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(468, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "ទំនាក់ទំនង";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Khmer OS System", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(914, 36);
            this.label6.TabIndex = 32;
            this.label6.Text = "ព័ត៌មានលំអិត";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(12, 349);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(160, 37);
            this.cboCate.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 36);
            this.label7.TabIndex = 34;
            this.label7.Text = "ប្រភេទទំនិញ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 36);
            this.label8.TabIndex = 36;
            this.label8.Text = "ឈ្មោះទំនិញ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPro
            // 
            this.cboPro.FormattingEnabled = true;
            this.cboPro.Location = new System.Drawing.Point(362, 349);
            this.cboPro.Name = "cboPro";
            this.cboPro.Size = new System.Drawing.Size(204, 37);
            this.cboPro.TabIndex = 35;
            this.cboPro.SelectionChangeCommitted += new System.EventHandler(this.cboPro_SelectionChangeCommitted);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(572, 349);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(111, 36);
            this.txtQty.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(572, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 36);
            this.label9.TabIndex = 38;
            this.label9.Text = "បរិមាណ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(689, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 36);
            this.label10.TabIndex = 40;
            this.label10.Text = "តម្លៃ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(689, 349);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 36);
            this.txtPrice.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::SaleInv.Properties.Resources.New_25;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(806, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = global::SaleInv.Properties.Resources.Close_25__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(828, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 36);
            this.btnClose.TabIndex = 31;
            this.btnClose.Tag = "*";
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = global::SaleInv.Properties.Resources.Save_25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(828, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Image = global::SaleInv.Properties.Resources.Plus_251;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(828, 86);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 36);
            this.btnNew.TabIndex = 29;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNewSup
            // 
            this.btnNewSup.BackColor = System.Drawing.Color.White;
            this.btnNewSup.Image = global::SaleInv.Properties.Resources.Plus_25;
            this.btnNewSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSup.Location = new System.Drawing.Point(447, 169);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(143, 36);
            this.btnNewSup.TabIndex = 11;
            this.btnNewSup.Text = "New Supplier";
            this.btnNewSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSup.UseVisualStyleBackColor = false;
            this.btnNewSup.Click += new System.EventHandler(this.btnNewSup_Click);
            // 
            // lswImport
            // 
            this.lswImport.FullRowSelect = true;
            this.lswImport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lswImport.Location = new System.Drawing.Point(12, 392);
            this.lswImport.Name = "lswImport";
            this.lswImport.Size = new System.Drawing.Size(914, 251);
            this.lswImport.TabIndex = 43;
            this.lswImport.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(178, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 36);
            this.label11.TabIndex = 45;
            this.label11.Text = "លេខកូដទំនិញ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(178, 349);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(178, 36);
            this.txtProID.TabIndex = 44;
            this.txtProID.TextChanged += new System.EventHandler(this.txtProID_TextChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(618, 648);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 36);
            this.label12.TabIndex = 47;
            this.label12.Text = "តម្លៃសរុប";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(735, 649);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(191, 36);
            this.txtTotal.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Khmer OS Bokor", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(938, 77);
            this.label13.TabIndex = 48;
            this.label13.Text = "ព័ត៌មានអំពីការនាំចូលទំនិញ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::SaleInv.Properties.Resources.Delete_25;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(806, 348);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 36);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.lswImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboPro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNewSup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupCon);
            this.Controls.Add(this.cboSup);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.dtpImp);
            this.Controls.Add(this.txtImpID);
            this.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImpID;
        private System.Windows.Forms.DateTimePicker dtpImp;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.ComboBox cboSup;
        private System.Windows.Forms.TextBox txtSupCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPro;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lswImport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRemove;
    }
}