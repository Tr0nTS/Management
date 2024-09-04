
namespace QuanLyTrungTamNgoaiNgu
{
    partial class FrmThemGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemGiaoVien));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboDiaChi = new System.Windows.Forms.TextBox();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.chbGioiTinh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboEmail = new System.Windows.Forms.TextBox();
            this.tboDienThoai = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tboTen = new System.Windows.Forms.TextBox();
            this.tboHo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoBangCap = new System.Windows.Forms.Button();
            this.btoNgoaiNgu = new System.Windows.Forms.Button();
            this.dgvTrinhDoGiaoVien = new System.Windows.Forms.DataGridView();
            this.colTenNgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoThem = new System.Windows.Forms.Button();
            this.tboGhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbBangCap = new System.Windows.Forms.ComboBox();
            this.cbbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.btoLuu = new System.Windows.Forms.Button();
            this.erpMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grbGioiTinh.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDoGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "THÊM HỒ SƠ GIÁO VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboDiaChi);
            this.groupBox1.Controls.Add(this.grbGioiTinh);
            this.groupBox1.Controls.Add(this.chbGioiTinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboEmail);
            this.groupBox1.Controls.Add(this.tboDienThoai);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.tboTen);
            this.groupBox1.Controls.Add(this.tboHo);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Địa chỉ";
            // 
            // tboDiaChi
            // 
            this.tboDiaChi.Location = new System.Drawing.Point(101, 86);
            this.tboDiaChi.Name = "tboDiaChi";
            this.tboDiaChi.Size = new System.Drawing.Size(460, 25);
            this.tboDiaChi.TabIndex = 5;
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.rdbNu);
            this.grbGioiTinh.Controls.Add(this.rdbNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(587, 30);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(122, 58);
            this.grbGioiTinh.TabIndex = 4;
            this.grbGioiTinh.TabStop = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(69, 24);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(46, 21);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(6, 24);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 21);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // chbGioiTinh
            // 
            this.chbGioiTinh.AutoSize = true;
            this.chbGioiTinh.Checked = true;
            this.chbGioiTinh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGioiTinh.Location = new System.Drawing.Point(500, 54);
            this.chbGioiTinh.Name = "chbGioiTinh";
            this.chbGioiTinh.Size = new System.Drawing.Size(81, 21);
            this.chbGioiTinh.TabIndex = 3;
            this.chbGioiTinh.Text = "Giới tính";
            this.chbGioiTinh.UseVisualStyleBackColor = true;
            this.chbGioiTinh.CheckedChanged += new System.EventHandler(this.chbGioiTinh_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ tên";
            // 
            // tboEmail
            // 
            this.tboEmail.Location = new System.Drawing.Point(304, 117);
            this.tboEmail.Name = "tboEmail";
            this.tboEmail.Size = new System.Drawing.Size(257, 25);
            this.tboEmail.TabIndex = 7;
            // 
            // tboDienThoai
            // 
            this.tboDienThoai.Location = new System.Drawing.Point(101, 117);
            this.tboDienThoai.Name = "tboDienThoai";
            this.tboDienThoai.Size = new System.Drawing.Size(113, 25);
            this.tboDienThoai.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(101, 55);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(113, 25);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // tboTen
            // 
            this.tboTen.Location = new System.Drawing.Point(220, 24);
            this.tboTen.Name = "tboTen";
            this.tboTen.Size = new System.Drawing.Size(246, 25);
            this.tboTen.TabIndex = 1;
            // 
            // tboHo
            // 
            this.tboHo.Location = new System.Drawing.Point(101, 24);
            this.tboHo.Name = "tboHo";
            this.tboHo.Size = new System.Drawing.Size(113, 25);
            this.tboHo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btoBangCap);
            this.groupBox3.Controls.Add(this.btoNgoaiNgu);
            this.groupBox3.Controls.Add(this.dgvTrinhDoGiaoVien);
            this.groupBox3.Controls.Add(this.btoXoa);
            this.groupBox3.Controls.Add(this.btoThem);
            this.groupBox3.Controls.Add(this.tboGhiChu);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbbBangCap);
            this.groupBox3.Controls.Add(this.cbbNgoaiNgu);
            this.groupBox3.Location = new System.Drawing.Point(12, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(920, 303);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trình độ giáo viên";
            // 
            // btoBangCap
            // 
            this.btoBangCap.Location = new System.Drawing.Point(450, 30);
            this.btoBangCap.Name = "btoBangCap";
            this.btoBangCap.Size = new System.Drawing.Size(30, 25);
            this.btoBangCap.TabIndex = 3;
            this.btoBangCap.Text = "...";
            this.btoBangCap.UseVisualStyleBackColor = true;
            this.btoBangCap.Click += new System.EventHandler(this.btoBangCap_Click);
            // 
            // btoNgoaiNgu
            // 
            this.btoNgoaiNgu.Location = new System.Drawing.Point(221, 30);
            this.btoNgoaiNgu.Name = "btoNgoaiNgu";
            this.btoNgoaiNgu.Size = new System.Drawing.Size(30, 25);
            this.btoNgoaiNgu.TabIndex = 1;
            this.btoNgoaiNgu.Text = "...";
            this.btoNgoaiNgu.UseVisualStyleBackColor = true;
            this.btoNgoaiNgu.Click += new System.EventHandler(this.btoNgoaiNgu_Click);
            // 
            // dgvTrinhDoGiaoVien
            // 
            this.dgvTrinhDoGiaoVien.AllowUserToAddRows = false;
            this.dgvTrinhDoGiaoVien.AllowUserToDeleteRows = false;
            this.dgvTrinhDoGiaoVien.AllowUserToResizeColumns = false;
            this.dgvTrinhDoGiaoVien.AllowUserToResizeRows = false;
            this.dgvTrinhDoGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrinhDoGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrinhDoGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenNgoaiNgu,
            this.colTenBangCap,
            this.colGhiChu});
            this.dgvTrinhDoGiaoVien.Location = new System.Drawing.Point(10, 65);
            this.dgvTrinhDoGiaoVien.MultiSelect = false;
            this.dgvTrinhDoGiaoVien.Name = "dgvTrinhDoGiaoVien";
            this.dgvTrinhDoGiaoVien.ReadOnly = true;
            this.dgvTrinhDoGiaoVien.RowHeadersWidth = 62;
            this.dgvTrinhDoGiaoVien.RowTemplate.Height = 28;
            this.dgvTrinhDoGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrinhDoGiaoVien.Size = new System.Drawing.Size(904, 232);
            this.dgvTrinhDoGiaoVien.TabIndex = 7;
            // 
            // colTenNgoaiNgu
            // 
            this.colTenNgoaiNgu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNgoaiNgu.DataPropertyName = "TenNgoaiNgu";
            this.colTenNgoaiNgu.HeaderText = "Ngoại ngữ";
            this.colTenNgoaiNgu.Name = "colTenNgoaiNgu";
            this.colTenNgoaiNgu.ReadOnly = true;
            // 
            // colTenBangCap
            // 
            this.colTenBangCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenBangCap.DataPropertyName = "TenBangCap";
            this.colTenBangCap.HeaderText = "Bằng cấp";
            this.colTenBangCap.Name = "colTenBangCap";
            this.colTenBangCap.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.FillWeight = 150F;
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // btoXoa
            // 
            this.btoXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoXoa.Enabled = false;
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(814, 24);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(100, 35);
            this.btoXoa.TabIndex = 6;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(709, 24);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(100, 35);
            this.btoThem.TabIndex = 5;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // tboGhiChu
            // 
            this.tboGhiChu.Location = new System.Drawing.Point(550, 30);
            this.tboGhiChu.Name = "tboGhiChu";
            this.tboGhiChu.Size = new System.Drawing.Size(153, 25);
            this.tboGhiChu.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ghi chú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Bằng cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngoại ngữ";
            // 
            // cbbBangCap
            // 
            this.cbbBangCap.DisplayMember = "TenBangCap";
            this.cbbBangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBangCap.FormattingEnabled = true;
            this.cbbBangCap.Location = new System.Drawing.Point(331, 30);
            this.cbbBangCap.Name = "cbbBangCap";
            this.cbbBangCap.Size = new System.Drawing.Size(113, 25);
            this.cbbBangCap.TabIndex = 2;
            this.cbbBangCap.ValueMember = "MaBangCap";
            // 
            // cbbNgoaiNgu
            // 
            this.cbbNgoaiNgu.DisplayMember = "TenNgoaiNgu";
            this.cbbNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNgoaiNgu.FormattingEnabled = true;
            this.cbbNgoaiNgu.Location = new System.Drawing.Point(102, 30);
            this.cbbNgoaiNgu.Name = "cbbNgoaiNgu";
            this.cbbNgoaiNgu.Size = new System.Drawing.Size(113, 25);
            this.cbbNgoaiNgu.TabIndex = 0;
            this.cbbNgoaiNgu.ValueMember = "MaNgoaiNgu";
            // 
            // btoLuu
            // 
            this.btoLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btoLuu.Image = ((System.Drawing.Image)(resources.GetObject("btoLuu.Image")));
            this.btoLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoLuu.Location = new System.Drawing.Point(422, 515);
            this.btoLuu.Name = "btoLuu";
            this.btoLuu.Size = new System.Drawing.Size(100, 35);
            this.btoLuu.TabIndex = 15;
            this.btoLuu.Text = "Lưu";
            this.btoLuu.UseVisualStyleBackColor = true;
            this.btoLuu.Click += new System.EventHandler(this.btoLuu_Click);
            // 
            // erpMessage
            // 
            this.erpMessage.ContainerControl = this;
            // 
            // FrmThemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 562);
            this.Controls.Add(this.btoLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThemGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM GIÁO VIÊN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDoGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.CheckBox chbGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboEmail;
        private System.Windows.Forms.TextBox tboDienThoai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox tboTen;
        private System.Windows.Forms.TextBox tboHo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboDiaChi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tboGhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbBangCap;
        private System.Windows.Forms.ComboBox cbbNgoaiNgu;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.DataGridView dgvTrinhDoGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBangCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Button btoLuu;
        private System.Windows.Forms.ErrorProvider erpMessage;
        private System.Windows.Forms.Button btoNgoaiNgu;
        private System.Windows.Forms.Button btoBangCap;
    }
}