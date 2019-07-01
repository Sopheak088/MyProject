namespace SaleInv
{
    partial class frmSale
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.lswSale = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCusCon = new System.Windows.Forms.TextBox();
            this.cboCus = new System.Windows.Forms.ComboBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.dtpSale = new System.Windows.Forms.DateTimePicker();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNewCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Khmer OS Bokor", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(0, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(938, 77);
            this.label13.TabIndex = 79;
            this.label13.Text = "ព័ត៌មានអំពីការលក់ទំនិញ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(618, 649);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 36);
            this.label12.TabIndex = 78;
            this.label12.Text = "តម្លៃសរុប";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(735, 650);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(191, 36);
            this.txtTotal.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 36);
            this.label11.TabIndex = 76;
            this.label11.Text = "លេខកូដទំនិញ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(13, 351);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(178, 36);
            this.txtProID.TabIndex = 75;
            this.txtProID.TextChanged += new System.EventHandler(this.txtProID_TextChanged);
            // 
            // lswSale
            // 
            this.lswSale.FullRowSelect = true;
            this.lswSale.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lswSale.Location = new System.Drawing.Point(12, 393);
            this.lswSale.Name = "lswSale";
            this.lswSale.Size = new System.Drawing.Size(914, 251);
            this.lswSale.TabIndex = 74;
            this.lswSale.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 36);
            this.label10.TabIndex = 72;
            this.label10.Text = "តម្លៃ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(524, 351);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 36);
            this.txtPrice.TabIndex = 71;
            this.txtPrice.Tag = "*";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 36);
            this.label9.TabIndex = 70;
            this.label9.Text = "បរិមាណ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(407, 351);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(111, 36);
            this.txtQty.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 36);
            this.label8.TabIndex = 68;
            this.label8.Text = "ឈ្មោះទំនិញ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPro
            // 
            this.cboPro.FormattingEnabled = true;
            this.cboPro.Location = new System.Drawing.Point(197, 351);
            this.cboPro.Name = "cboPro";
            this.cboPro.Size = new System.Drawing.Size(204, 37);
            this.cboPro.TabIndex = 67;
            this.cboPro.SelectionChangeCommitted += new System.EventHandler(this.cboPro_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(640, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 36);
            this.label7.TabIndex = 66;
            this.label7.Text = "ប្រភេទទំនិញ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCate
            // 
            this.cboCate.Enabled = false;
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(640, 351);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(160, 37);
            this.cboCate.TabIndex = 65;
            this.cboCate.Tag = "*";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Khmer OS System", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(914, 36);
            this.label6.TabIndex = 64;
            this.label6.Text = "ព័ត៌មានលំអិត";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(468, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 36);
            this.label5.TabIndex = 59;
            this.label5.Text = "ទំនាក់ទំនង";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 36);
            this.label4.TabIndex = 58;
            this.label4.Text = "ឈ្មោះអតិថិជន";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "លេខសម្គាល់អតិថិជន";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 36);
            this.label2.TabIndex = 56;
            this.label2.Text = "កាលបរិច្ឆេទលក់";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 55;
            this.label1.Text = "លេខវិក័យបត្រ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCusCon
            // 
            this.txtCusCon.Location = new System.Drawing.Point(596, 87);
            this.txtCusCon.Multiline = true;
            this.txtCusCon.Name = "txtCusCon";
            this.txtCusCon.Size = new System.Drawing.Size(204, 78);
            this.txtCusCon.TabIndex = 54;
            // 
            // cboCus
            // 
            this.cboCus.FormattingEnabled = true;
            this.cboCus.Location = new System.Drawing.Point(237, 212);
            this.cboCus.Name = "cboCus";
            this.cboCus.Size = new System.Drawing.Size(204, 37);
            this.cboCus.TabIndex = 53;
            this.cboCus.SelectionChangeCommitted += new System.EventHandler(this.cboCus_SelectionChangeCommitted);
            // 
            // txtCusID
            // 
            this.txtCusID.Enabled = false;
            this.txtCusID.Location = new System.Drawing.Point(237, 170);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(204, 36);
            this.txtCusID.TabIndex = 52;
            this.txtCusID.Tag = "*";
            // 
            // dtpSale
            // 
            this.dtpSale.CustomFormat = "dd/MM/yyyy";
            this.dtpSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSale.Location = new System.Drawing.Point(237, 128);
            this.dtpSale.Name = "dtpSale";
            this.dtpSale.Size = new System.Drawing.Size(204, 36);
            this.dtpSale.TabIndex = 51;
            this.dtpSale.Tag = "*";
            // 
            // txtSaleID
            // 
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Location = new System.Drawing.Point(237, 86);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(204, 36);
            this.txtSaleID.TabIndex = 50;
            this.txtSaleID.Tag = "*";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::SaleInv.Properties.Resources.New_25;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(806, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::SaleInv.Properties.Resources.Delete_25;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(806, 349);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 36);
            this.btnRemove.TabIndex = 80;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = global::SaleInv.Properties.Resources.Close_25__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(828, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 36);
            this.btnClose.TabIndex = 63;
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
            this.btnSave.Location = new System.Drawing.Point(828, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 62;
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
            this.btnNew.Location = new System.Drawing.Point(828, 87);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 36);
            this.btnNew.TabIndex = 61;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNewCus
            // 
            this.btnNewCus.BackColor = System.Drawing.Color.White;
            this.btnNewCus.Image = global::SaleInv.Properties.Resources.Plus_25;
            this.btnNewCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCus.Location = new System.Drawing.Point(447, 170);
            this.btnNewCus.Name = "btnNewCus";
            this.btnNewCus.Size = new System.Drawing.Size(150, 36);
            this.btnNewCus.TabIndex = 60;
            this.btnNewCus.Text = "New Customer";
            this.btnNewCus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCus.UseVisualStyleBackColor = false;
            this.btnNewCus.Click += new System.EventHandler(this.btnNewCus_Click);
            // 
            // frmSale
            // 
            this.AcceptButton = this.btnAdd;
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
            this.Controls.Add(this.lswSale);
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
            this.Controls.Add(this.btnNewCus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCusCon);
            this.Controls.Add(this.cboCus);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.dtpSale);
            this.Controls.Add(this.txtSaleID);
            this.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.ListView lswSale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNewCus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCusCon;
        private System.Windows.Forms.ComboBox cboCus;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.DateTimePicker dtpSale;
        private System.Windows.Forms.TextBox txtSaleID;
    }
}