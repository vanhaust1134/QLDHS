namespace QLDHS
{
    partial class frmHocSinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMAHS = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.cboMALOP = new System.Windows.Forms.ComboBox();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ:";
            // 
            // txtMAHS
            // 
            this.txtMAHS.Location = new System.Drawing.Point(132, 29);
            this.txtMAHS.Name = "txtMAHS";
            this.txtMAHS.Size = new System.Drawing.Size(228, 34);
            this.txtMAHS.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(132, 83);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(228, 34);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(527, 141);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(314, 34);
            this.txtDC.TabIndex = 8;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(527, 30);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(82, 31);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "NAM";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(686, 30);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(68, 31);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "NỮ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNS.Location = new System.Drawing.Point(527, 83);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(201, 34);
            this.dtpNS.TabIndex = 11;
            // 
            // cboMALOP
            // 
            this.cboMALOP.FormattingEnabled = true;
            this.cboMALOP.Location = new System.Drawing.Point(132, 141);
            this.cboMALOP.Name = "cboMALOP";
            this.cboMALOP.Size = new System.Drawing.Size(228, 35);
            this.cboMALOP.TabIndex = 12;
            // 
            // dgvHS
            // 
            this.dgvHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHS.Location = new System.Drawing.Point(0, 295);
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.RowTemplate.Height = 28;
            this.dgvHS.Size = new System.Drawing.Size(864, 250);
            this.dgvHS.TabIndex = 13;
            this.dgvHS.Click += new System.EventHandler(this.dgvHS_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(160, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 55);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(292, 234);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 55);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(426, 234);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 55);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(551, 234);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 55);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 545);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHS);
            this.Controls.Add(this.cboMALOP);
            this.Controls.Add(this.dtpNS);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMAHS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHocSinh";
            this.Text = "frmHocSinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMAHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.ComboBox cboMALOP;
        private System.Windows.Forms.DataGridView dgvHS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
    }
}