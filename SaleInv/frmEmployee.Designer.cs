namespace SaleInv
{
    partial class frmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoF = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpHire = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picEmp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "ព័ត៌មានរបស់បុគ្គលិក";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(141, 26);
            this.txtID.TabIndex = 0;
            this.txtID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "អត្តលេខ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ឈ្មោះ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 26);
            this.txtName.TabIndex = 1;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ភេទ";
            // 
            // rdoF
            // 
            this.rdoF.AutoSize = true;
            this.rdoF.Location = new System.Drawing.Point(120, 176);
            this.rdoF.Name = "rdoF";
            this.rdoF.Size = new System.Drawing.Size(41, 24);
            this.rdoF.TabIndex = 2;
            this.rdoF.TabStop = true;
            this.rdoF.Text = "ស្រី";
            this.rdoF.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(194, 176);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(51, 24);
            this.rdoM.TabIndex = 3;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "ប្រុស";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(120, 215);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(141, 26);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            this.dtpDOB.Enter += new System.EventHandler(this.dtpDOB_Enter);
            this.dtpDOB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ថ្ងៃកំណើត";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "តួនាទី";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(120, 257);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(141, 26);
            this.txtPos.TabIndex = 5;
            this.txtPos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            this.txtPos.Leave += new System.EventHandler(this.txtPos_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "ប្រាក់ខែ";
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(423, 89);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(141, 26);
            this.txtSal.TabIndex = 6;
            this.txtSal.Enter += new System.EventHandler(this.txtSal_Enter);
            this.txtSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSal_KeyPress);
            this.txtSal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            this.txtSal.Leave += new System.EventHandler(this.txtSal_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "អាសយដ្ឋាន";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(423, 131);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(141, 78);
            this.txtAdd.TabIndex = 7;
            this.txtAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "ថ្ងៃចូលធ្វើការ";
            // 
            // dtpHire
            // 
            this.dtpHire.CustomFormat = "dd/MM/yyyy";
            this.dtpHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHire.Location = new System.Drawing.Point(423, 215);
            this.dtpHire.Name = "dtpHire";
            this.dtpHire.Size = new System.Drawing.Size(141, 26);
            this.dtpHire.TabIndex = 8;
            this.dtpHire.ValueChanged += new System.EventHandler(this.dtpHire_ValueChanged);
            this.dtpHire.Enter += new System.EventHandler(this.dtpDOB_Enter);
            this.dtpHire.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "លេខទូរសព្ទ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 341);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(730, 26);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Tag = "*";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(423, 257);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(141, 26);
            this.txtContact.TabIndex = 9;
            this.txtContact.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.EnableHeadersVisualStyles = false;
            this.dgvEmp.Location = new System.Drawing.Point(12, 383);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.RowHeadersVisible = false;
            this.dgvEmp.RowTemplate.Height = 80;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmp.Size = new System.Drawing.Size(730, 280);
            this.dgvEmp.TabIndex = 22;
            this.dgvEmp.Tag = "*";
            this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = global::SaleInv.Properties.Resources.Close_25__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(642, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 13;
            this.btnClose.Tag = "*";
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::SaleInv.Properties.Resources.print_25;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(536, 299);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 36);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Tag = "*";
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::SaleInv.Properties.Resources.Delete_25;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(430, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::SaleInv.Properties.Resources.edit_25;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(324, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 36);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = global::SaleInv.Properties.Resources.Save_25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(218, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Image = global::SaleInv.Properties.Resources.Plus_25;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(112, 299);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 36);
            this.btnNew.TabIndex = 12;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.Image = global::SaleInv.Properties.Resources.folder_25;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(620, 215);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(122, 36);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picEmp
            // 
            this.picEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEmp.Location = new System.Drawing.Point(620, 89);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(122, 120);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmp.TabIndex = 21;
            this.picEmp.TabStop = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(757, 675);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpHire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rdoM);
            this.Controls.Add(this.rdoF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee\'s Info";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoF;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpHire;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DataGridView dgvEmp;
    }
}