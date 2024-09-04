namespace QuanLyTrungTamNgoaiNgu
{
    partial class FrmQuanLyBangCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyBangCap));
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.btoDong = new System.Windows.Forms.Button();
            this.chbMaBangCap = new System.Windows.Forms.CheckBox();
            this.chbTenBangCap = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboMaBangCap = new System.Windows.Forms.TextBox();
            this.tboTenBangCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.dgvBangCap = new System.Windows.Forms.DataGridView();
            this.btoThem = new System.Windows.Forms.Button();
            this.chbTimKiem = new System.Windows.Forms.CheckBox();
            this.colMaBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).BeginInit();
            this.SuspendLayout();
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Enabled = false;
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(447, 141);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(100, 35);
            this.btoTimKiem.TabIndex = 24;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            // 
            // btoDong
            // 
            this.btoDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoDong.Location = new System.Drawing.Point(834, 141);
            this.btoDong.Name = "btoDong";
            this.btoDong.Size = new System.Drawing.Size(100, 35);
            this.btoDong.TabIndex = 22;
            this.btoDong.Text = "Đóng";
            this.btoDong.UseVisualStyleBackColor = true;
            // 
            // chbMaBangCap
            // 
            this.chbMaBangCap.AutoSize = true;
            this.chbMaBangCap.Checked = true;
            this.chbMaBangCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMaBangCap.Location = new System.Drawing.Point(6, 25);
            this.chbMaBangCap.Name = "chbMaBangCap";
            this.chbMaBangCap.Size = new System.Drawing.Size(110, 21);
            this.chbMaBangCap.TabIndex = 16;
            this.chbMaBangCap.Text = "Mã bằng cấp";
            this.chbMaBangCap.UseVisualStyleBackColor = true;
            // 
            // chbTenBangCap
            // 
            this.chbTenBangCap.AutoSize = true;
            this.chbTenBangCap.Checked = true;
            this.chbTenBangCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTenBangCap.Location = new System.Drawing.Point(6, 55);
            this.chbTenBangCap.Name = "chbTenBangCap";
            this.chbTenBangCap.Size = new System.Drawing.Size(116, 21);
            this.chbTenBangCap.TabIndex = 15;
            this.chbTenBangCap.Text = "Tên bằng cấp";
            this.chbTenBangCap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chbMaBangCap);
            this.groupBox1.Controls.Add(this.chbTenBangCap);
            this.groupBox1.Controls.Add(this.tboMaBangCap);
            this.groupBox1.Controls.Add(this.tboTenBangCap);
            this.groupBox1.Location = new System.Drawing.Point(14, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 91);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bằng cấp";
            // 
            // tboMaBangCap
            // 
            this.tboMaBangCap.Location = new System.Drawing.Point(133, 23);
            this.tboMaBangCap.Name = "tboMaBangCap";
            this.tboMaBangCap.Size = new System.Drawing.Size(100, 25);
            this.tboMaBangCap.TabIndex = 1;
            // 
            // tboTenBangCap
            // 
            this.tboTenBangCap.Location = new System.Drawing.Point(133, 53);
            this.tboTenBangCap.Name = "tboTenBangCap";
            this.tboTenBangCap.Size = new System.Drawing.Size(367, 25);
            this.tboTenBangCap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "QUẢN LÝ DANH SÁCH BẰNG CẤP";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 17);
            this.lblStatus.Text = "Thông báo:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(341, 141);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(100, 35);
            this.btoXoa.TabIndex = 18;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoSua.Location = new System.Drawing.Point(235, 141);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(100, 35);
            this.btoSua.TabIndex = 17;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            // 
            // dgvBangCap
            // 
            this.dgvBangCap.AllowUserToAddRows = false;
            this.dgvBangCap.AllowUserToDeleteRows = false;
            this.dgvBangCap.AllowUserToResizeColumns = false;
            this.dgvBangCap.AllowUserToResizeRows = false;
            this.dgvBangCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBangCap,
            this.colTenBangCap});
            this.dgvBangCap.Location = new System.Drawing.Point(14, 182);
            this.dgvBangCap.MultiSelect = false;
            this.dgvBangCap.Name = "dgvBangCap";
            this.dgvBangCap.ReadOnly = true;
            this.dgvBangCap.RowHeadersWidth = 62;
            this.dgvBangCap.RowTemplate.Height = 28;
            this.dgvBangCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangCap.Size = new System.Drawing.Size(920, 354);
            this.dgvBangCap.TabIndex = 16;
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(129, 141);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(100, 35);
            this.btoThem.TabIndex = 15;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            // 
            // chbTimKiem
            // 
            this.chbTimKiem.AutoSize = true;
            this.chbTimKiem.Location = new System.Drawing.Point(14, 149);
            this.chbTimKiem.Name = "chbTimKiem";
            this.chbTimKiem.Size = new System.Drawing.Size(87, 21);
            this.chbTimKiem.TabIndex = 23;
            this.chbTimKiem.Text = "Tìm kiếm";
            this.chbTimKiem.UseVisualStyleBackColor = true;
            // 
            // colMaBangCap
            // 
            this.colMaBangCap.DataPropertyName = "MaBangCap";
            this.colMaBangCap.HeaderText = "Mã bằng cấp";
            this.colMaBangCap.MinimumWidth = 8;
            this.colMaBangCap.Name = "colMaBangCap";
            this.colMaBangCap.ReadOnly = true;
            this.colMaBangCap.Width = 200;
            // 
            // colTenBangCap
            // 
            this.colTenBangCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenBangCap.DataPropertyName = "TenBangCap";
            this.colTenBangCap.HeaderText = "Tên bằng cấp";
            this.colTenBangCap.MinimumWidth = 8;
            this.colTenBangCap.Name = "colTenBangCap";
            this.colTenBangCap.ReadOnly = true;
            // 
            // FrmQuanLyBangCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.btoTimKiem);
            this.Controls.Add(this.btoDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btoXoa);
            this.Controls.Add(this.btoSua);
            this.Controls.Add(this.dgvBangCap);
            this.Controls.Add(this.btoThem);
            this.Controls.Add(this.chbTimKiem);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuanLyBangCap";
            this.Text = "QUẢN LÝ DANH SÁCH BẰNG CẤP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.Button btoDong;
        private System.Windows.Forms.CheckBox chbMaBangCap;
        private System.Windows.Forms.CheckBox chbTenBangCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboMaBangCap;
        private System.Windows.Forms.TextBox tboTenBangCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.DataGridView dgvBangCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBangCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBangCap;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.CheckBox chbTimKiem;
    }
}