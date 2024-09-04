
namespace QuanLyTrungTamNgoaiNgu
{
    partial class FrmQuanLyNgoaiNgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNgoaiNgu));
            this.tboMaNgoaiNgu = new System.Windows.Forms.TextBox();
            this.tboTenNgoaiNgu = new System.Windows.Forms.TextBox();
            this.btoThem = new System.Windows.Forms.Button();
            this.dgvNgoaiNgu = new System.Windows.Forms.DataGridView();
            this.colMaNgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoSua = new System.Windows.Forms.Button();
            this.btoXoa = new System.Windows.Forms.Button();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbMaNgoaiNgu = new System.Windows.Forms.CheckBox();
            this.chbTenNgoaiNgu = new System.Windows.Forms.CheckBox();
            this.btoDong = new System.Windows.Forms.Button();
            this.chbTimKiem = new System.Windows.Forms.CheckBox();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.trvGiaoVien = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboMaNgoaiNgu
            // 
            this.tboMaNgoaiNgu.Location = new System.Drawing.Point(133, 23);
            this.tboMaNgoaiNgu.Name = "tboMaNgoaiNgu";
            this.tboMaNgoaiNgu.Size = new System.Drawing.Size(100, 24);
            this.tboMaNgoaiNgu.TabIndex = 1;
            // 
            // tboTenNgoaiNgu
            // 
            this.tboTenNgoaiNgu.Location = new System.Drawing.Point(133, 53);
            this.tboTenNgoaiNgu.Name = "tboTenNgoaiNgu";
            this.tboTenNgoaiNgu.Size = new System.Drawing.Size(367, 24);
            this.tboTenNgoaiNgu.TabIndex = 2;
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(127, 141);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(100, 35);
            this.btoThem.TabIndex = 5;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            this.btoThem.MouseLeave += new System.EventHandler(this.btoThem_MouseLeave);
            this.btoThem.MouseHover += new System.EventHandler(this.btoThem_MouseHover);
            // 
            // dgvNgoaiNgu
            // 
            this.dgvNgoaiNgu.AllowUserToAddRows = false;
            this.dgvNgoaiNgu.AllowUserToDeleteRows = false;
            this.dgvNgoaiNgu.AllowUserToResizeColumns = false;
            this.dgvNgoaiNgu.AllowUserToResizeRows = false;
            this.dgvNgoaiNgu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNgoaiNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgoaiNgu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNgoaiNgu,
            this.colTenNgoaiNgu});
            this.dgvNgoaiNgu.Location = new System.Drawing.Point(12, 182);
            this.dgvNgoaiNgu.MultiSelect = false;
            this.dgvNgoaiNgu.Name = "dgvNgoaiNgu";
            this.dgvNgoaiNgu.ReadOnly = true;
            this.dgvNgoaiNgu.RowHeadersWidth = 62;
            this.dgvNgoaiNgu.RowTemplate.Height = 28;
            this.dgvNgoaiNgu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNgoaiNgu.Size = new System.Drawing.Size(679, 354);
            this.dgvNgoaiNgu.TabIndex = 6;
            this.dgvNgoaiNgu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgoaiNgu_RowEnter);
            // 
            // colMaNgoaiNgu
            // 
            this.colMaNgoaiNgu.DataPropertyName = "MaNgoaiNgu";
            this.colMaNgoaiNgu.HeaderText = "Mã ngoại ngữ";
            this.colMaNgoaiNgu.MinimumWidth = 8;
            this.colMaNgoaiNgu.Name = "colMaNgoaiNgu";
            this.colMaNgoaiNgu.ReadOnly = true;
            this.colMaNgoaiNgu.Width = 200;
            // 
            // colTenNgoaiNgu
            // 
            this.colTenNgoaiNgu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNgoaiNgu.DataPropertyName = "TenNgoaiNgu";
            this.colTenNgoaiNgu.HeaderText = "Tên ngoại ngữ";
            this.colTenNgoaiNgu.MinimumWidth = 8;
            this.colTenNgoaiNgu.Name = "colTenNgoaiNgu";
            this.colTenNgoaiNgu.ReadOnly = true;
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoSua.Location = new System.Drawing.Point(233, 141);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(100, 35);
            this.btoSua.TabIndex = 7;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(339, 141);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(100, 35);
            this.btoXoa.TabIndex = 8;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 17);
            this.lblStatus.Text = "Thông báo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "QUẢN LÝ DANH SÁCH NGOẠI NGỮ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chbMaNgoaiNgu);
            this.groupBox1.Controls.Add(this.chbTenNgoaiNgu);
            this.groupBox1.Controls.Add(this.tboMaNgoaiNgu);
            this.groupBox1.Controls.Add(this.tboTenNgoaiNgu);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngoại ngữ";
            // 
            // chbMaNgoaiNgu
            // 
            this.chbMaNgoaiNgu.AutoSize = true;
            this.chbMaNgoaiNgu.Checked = true;
            this.chbMaNgoaiNgu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMaNgoaiNgu.Location = new System.Drawing.Point(6, 25);
            this.chbMaNgoaiNgu.Name = "chbMaNgoaiNgu";
            this.chbMaNgoaiNgu.Size = new System.Drawing.Size(115, 21);
            this.chbMaNgoaiNgu.TabIndex = 16;
            this.chbMaNgoaiNgu.Text = "Mã ngoại ngữ";
            this.chbMaNgoaiNgu.UseVisualStyleBackColor = true;
            // 
            // chbTenNgoaiNgu
            // 
            this.chbTenNgoaiNgu.AutoSize = true;
            this.chbTenNgoaiNgu.Checked = true;
            this.chbTenNgoaiNgu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTenNgoaiNgu.Location = new System.Drawing.Point(6, 55);
            this.chbTenNgoaiNgu.Name = "chbTenNgoaiNgu";
            this.chbTenNgoaiNgu.Size = new System.Drawing.Size(121, 21);
            this.chbTenNgoaiNgu.TabIndex = 15;
            this.chbTenNgoaiNgu.Text = "Tên ngoại ngữ";
            this.chbTenNgoaiNgu.UseVisualStyleBackColor = true;
            // 
            // btoDong
            // 
            this.btoDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoDong.Location = new System.Drawing.Point(832, 141);
            this.btoDong.Name = "btoDong";
            this.btoDong.Size = new System.Drawing.Size(100, 35);
            this.btoDong.TabIndex = 12;
            this.btoDong.Text = "Đóng";
            this.btoDong.UseVisualStyleBackColor = true;
            // 
            // chbTimKiem
            // 
            this.chbTimKiem.AutoSize = true;
            this.chbTimKiem.Location = new System.Drawing.Point(12, 149);
            this.chbTimKiem.Name = "chbTimKiem";
            this.chbTimKiem.Size = new System.Drawing.Size(87, 21);
            this.chbTimKiem.TabIndex = 13;
            this.chbTimKiem.Text = "Tìm kiếm";
            this.chbTimKiem.UseVisualStyleBackColor = true;
            this.chbTimKiem.CheckedChanged += new System.EventHandler(this.chbTimKiem_CheckedChanged);
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Enabled = false;
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(445, 141);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(100, 35);
            this.btoTimKiem.TabIndex = 14;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // trvGiaoVien
            // 
            this.trvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvGiaoVien.Location = new System.Drawing.Point(697, 182);
            this.trvGiaoVien.Name = "trvGiaoVien";
            this.trvGiaoVien.Size = new System.Drawing.Size(235, 354);
            this.trvGiaoVien.TabIndex = 15;
            // 
            // FrmQuanLyNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.trvGiaoVien);
            this.Controls.Add(this.btoTimKiem);
            this.Controls.Add(this.chbTimKiem);
            this.Controls.Add(this.btoDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btoXoa);
            this.Controls.Add(this.btoSua);
            this.Controls.Add(this.dgvNgoaiNgu);
            this.Controls.Add(this.btoThem);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLyNgoaiNgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DANH SÁCH NGOẠI NGỮ";
            this.Load += new System.EventHandler(this.FrmQuanLyNgoaiNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboMaNgoaiNgu;
        private System.Windows.Forms.TextBox tboTenNgoaiNgu;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.DataGridView dgvNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNgoaiNgu;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btoDong;
        private System.Windows.Forms.CheckBox chbTimKiem;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.CheckBox chbMaNgoaiNgu;
        private System.Windows.Forms.CheckBox chbTenNgoaiNgu;
        private System.Windows.Forms.TreeView trvGiaoVien;
    }
}

