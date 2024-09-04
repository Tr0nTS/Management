namespace QuanLyTrungTamNgoaiNgu
{
    partial class FrmMain
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
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.mniHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNgoaiNgu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBangCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQuanLyGiaoVienHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMain
            // 
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHeThong,
            this.mniDanhMuc,
            this.mniQuanLyGiaoVienHocVien});
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(944, 24);
            this.mstMain.TabIndex = 0;
            this.mstMain.Text = "menuStrip1";
            // 
            // mniHeThong
            // 
            this.mniHeThong.Name = "mniHeThong";
            this.mniHeThong.Size = new System.Drawing.Size(69, 20);
            this.mniHeThong.Text = "Hệ thống";
            // 
            // mniDanhMuc
            // 
            this.mniDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNgoaiNgu,
            this.mniBangCap});
            this.mniDanhMuc.Name = "mniDanhMuc";
            this.mniDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mniDanhMuc.Text = "Danh mục";
            // 
            // mniNgoaiNgu
            // 
            this.mniNgoaiNgu.Name = "mniNgoaiNgu";
            this.mniNgoaiNgu.Size = new System.Drawing.Size(130, 22);
            this.mniNgoaiNgu.Text = "Ngoại ngữ";
            this.mniNgoaiNgu.Click += new System.EventHandler(this.mniNgoaiNgu_Click);
            // 
            // mniBangCap
            // 
            this.mniBangCap.Name = "mniBangCap";
            this.mniBangCap.Size = new System.Drawing.Size(130, 22);
            this.mniBangCap.Text = "Bằng cấp";
            this.mniBangCap.Click += new System.EventHandler(this.mniBangCap_Click);
            // 
            // mniQuanLyGiaoVienHocVien
            // 
            this.mniQuanLyGiaoVienHocVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGiaoVien,
            this.mniHocVien});
            this.mniQuanLyGiaoVienHocVien.Name = "mniQuanLyGiaoVienHocVien";
            this.mniQuanLyGiaoVienHocVien.Size = new System.Drawing.Size(159, 20);
            this.mniQuanLyGiaoVienHocVien.Text = "Quản lý giáo viên học viên";
            // 
            // mniGiaoVien
            // 
            this.mniGiaoVien.Name = "mniGiaoVien";
            this.mniGiaoVien.Size = new System.Drawing.Size(180, 22);
            this.mniGiaoVien.Text = "Giáo viên";
            this.mniGiaoVien.Click += new System.EventHandler(this.mniGiaoVien_Click);
            // 
            // mniHocVien
            // 
            this.mniHocVien.Name = "mniHocVien";
            this.mniHocVien.Size = new System.Drawing.Size(180, 22);
            this.mniHocVien.Text = "Học viên";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.mstMain);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ TRUNG TÂM NGOẠI NGỮ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem mniHeThong;
        private System.Windows.Forms.ToolStripMenuItem mniDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mniNgoaiNgu;
        private System.Windows.Forms.ToolStripMenuItem mniBangCap;
        private System.Windows.Forms.ToolStripMenuItem mniQuanLyGiaoVienHocVien;
        private System.Windows.Forms.ToolStripMenuItem mniGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mniHocVien;
    }
}