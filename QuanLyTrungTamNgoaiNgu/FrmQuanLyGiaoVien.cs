using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FrmQuanLyGiaoVien : Form
    {
        private void loadCbbNgoaiNgu() 
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        private void loadCbbBangCap()
        {
            cbbBangCap.DataSource = Database.Query("SELECT * FROM BangCap", new Dictionary<string, object>());
        }
        private void loadDgvGiaoVien()
        {
            string strQuery = "SELECT DISTINCT GiaoVien.MaGiaoVien,Ho,Ten,NgaySinh,IIF(GioiTinh IS NULL,N'Không',IIF(GioiTinh='TRUE','Nam',N'Nữ')) GioiTinh,DiaChi,DienThoai,Email FROM GiaoVien LEFT JOIN TrinhDoGiaoVien ON GiaoVien.MaGiaoVien=TrinhDoGiaoVien.MaGiaoVien WHERE 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaGiaoVien.Checked)
            {
                strQuery += " AND GiaoVien.MaGiaoVien=@maGiaoVien";
                parameters.Add("@maGiaoVien", int.Parse(tboMaGiaoVien.Text));
            }
            if (chbHo.Checked)
            {
                strQuery += " AND Ho LIKE '%' + @ho + '%'";
                parameters.Add("@ho", tboHo.Text);
            }
            if (chbTen.Checked)
            {
                strQuery += " AND Ten LIKE '%' + @ten + '%'";
                parameters.Add("@ten", tboTen.Text);
            }
            if (chbNgaySinhTu.Checked)
            {
                strQuery += " AND NgaySinh>=@ngaySinhTu";
                parameters.Add("@ngaySinhTu", dtpNgaySinhTu.Value.Date);
            }
            if (chbNgaySinhDen.Checked)
            {
                strQuery += " AND NgaySinh<=@ngaySinhDen";
                parameters.Add("@ngaySinhDen", dtpNgaySinhDen.Value.AddDays(1).Date);
            }
            if (chbGioiTinh.Checked)
            {
                strQuery += " AND GioiTinh=@gioiTinh";
                parameters.Add("@gioiTinh", rdbNam.Checked);
            }
            if (chbDiaChi.Checked)
            {
                strQuery += " AND DiaChi LIKE '%' + @diaChi + '%'";
                parameters.Add("@diaChi", tboDiaChi.Text);
            }
            if (chbDienThoai.Checked)
            {
                strQuery += " AND DienThoai LIKE '%' + @dienThoai + '%'";
                parameters.Add("@dienThoai", tboDienThoai.Text);
            }
            if (chbEmail.Checked)
            {
                strQuery += " AND Email LIKE '%' + @email + '%'";
                parameters.Add("@email", tboEmail.Text);
            }
            if (chbNgoaiNgu.Checked)
            {
                strQuery += " AND MaNgoaiNgu = @maNgoaiNgu";
                parameters.Add("@maNgoaiNgu", cbbNgoaiNgu.SelectedValue);
            }
            if (chbBangCap.Checked)
            {
                strQuery += " AND MaBangCap = @maBangCap";
                parameters.Add("@maBangCap", cbbBangCap.SelectedValue);
            }
            dgvGiaoVien.DataSource = Database.Query(strQuery, parameters);
            btoSua.Enabled = btoXoa.Enabled = dgvGiaoVien.Rows.Count > 0;
        }
        public FrmQuanLyGiaoVien()
        {
            InitializeComponent();
            loadDgvGiaoVien();
            loadCbbNgoaiNgu();
            loadCbbBangCap();
        }

        private void chbMaGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            tboMaGiaoVien.Enabled = chbMaGiaoVien.Checked;
        }

        private void chbHo_CheckedChanged(object sender, EventArgs e)
        {
            tboHo.Enabled = chbHo.Checked;
        }

        private void chbTen_CheckedChanged(object sender, EventArgs e)
        {
            tboTen.Enabled = chbTen.Checked;
        }

        private void chbNgaySinhTu_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhTu.Enabled = chbNgaySinhTu.Checked;
        }

        private void chbNgaySinhDen_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhDen.Enabled = chbNgaySinhDen.Checked;
        }

        private void chbDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            tboDienThoai.Enabled = chbDienThoai.Checked;
        }

        private void chbEmail_CheckedChanged(object sender, EventArgs e)
        {
            tboEmail.Enabled = chbEmail.Checked;
        }

        private void chbNgoaiNgu_CheckedChanged(object sender, EventArgs e)
        {
            cbbNgoaiNgu.Enabled = chbNgoaiNgu.Checked;
        }

        private void chbBangCap_CheckedChanged(object sender, EventArgs e)
        {
            cbbBangCap.Enabled = chbBangCap.Checked;
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            FrmThemGiaoVien form = new FrmThemGiaoVien();
            form.ShowDialog();
            loadDgvGiaoVien();
        }

        private void chbDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            tboDiaChi.Enabled = chbDiaChi.Checked;
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvGiaoVien();
        }

        private void chbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            grbGioiTinh.Enabled = chbGioiTinh.Checked;
        }

        private void dgvGiaoVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboMaGiaoVienHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colMaGiaoVien"].Value.ToString();
            tboHoTenHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colHo"].Value.ToString() + " " + dgvGiaoVien.Rows[e.RowIndex].Cells["colTen"].Value.ToString();
            dtpNgaySinhHienThi.Value = DateTime.Parse(dgvGiaoVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            tboGioiTinhHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString();
            tboDiaChiHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            tboDienThoaiHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colDienThoai"].Value.ToString();
            tboEmailHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
            //Lấy ra mã giáo viên đang được chọn
            int maGiaoVien = int.Parse(tboMaGiaoVienHienThi.Text);
            //Dựa vào mã này để lấy ra các trình độ giáo viên tương ứng
            string strQuery = "SELECT TenNgoaiNgu,TenBangCap,GhiChu"
                + " FROM TrinhDoGiaoVien"
                + " INNER JOIN NgoaiNgu ON TrinhDoGiaoVien.MaNgoaiNgu = NgoaiNgu.MaNgoaiNgu"
                + " INNER JOIN BangCap ON TrinhDoGiaoVien.MaBangCap = BangCap.MaBangCap"
                + " WHERE MaGiaoVien=@maGiaoVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            DataTable trinhDoGiaoViens = Database.Query(strQuery, parameters);
            //Đẩy dữ liệu lên data gridview
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
            //Đẩy dữ liệu lên treeview
            trvTrinhDoGiaoVien.Nodes.Clear();
            for (int i = 0; i < trinhDoGiaoViens.Rows.Count; ++i)
            {
                TreeNode node = new TreeNode(trinhDoGiaoViens.Rows[i]["TenNgoaiNgu"].ToString());
                node.Nodes.Add("Bằng cấp: " + trinhDoGiaoViens.Rows[i]["TenBangCap"].ToString());
                if (trinhDoGiaoViens.Rows[i]["GhiChu"].ToString() != "")
                    node.Nodes.Add("Ghi chú: " + trinhDoGiaoViens.Rows[i]["GhiChu"].ToString());
                node.Expand();
                trvTrinhDoGiaoVien.Nodes.Add(node);
            }
        }

        private void chbHienThiNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colNgaySinh"].Visible = chbHienThiNgaySinh.Checked;
        }

        private void chbHienThiGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colGioiTinh"].Visible = chbHienThiGioiTinh.Checked;
        }

        private void chbHienThiDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colDiaChi"].Visible = chbHienThiDiaChi.Checked;
        }

        private void chbHienThiDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colDienThoai"].Visible = chbHienThiDienThoai.Checked;
        }

        private void chbHienThiEmail_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colEmail"].Visible = chbHienThiEmail.Checked;
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hồ sơ giáo viên này không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Lấy ra mã giáo viên của dòng đang chọn
                int maGiaoVien = (int)dgvGiaoVien.CurrentRow.Cells["colMaGiaoVien"].Value;
                //Xóa tất cả trình độ giáo viên ứng với mã vừa lấy
                string strCommand = "DELETE TrinhDoGiaoVien WHERE MaGiaoVien=@maGiaoVien";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maGiaoVien", maGiaoVien);
                Database.Execute(strCommand, parameters);
                //Xóa giáo viên có mã ứng với mã vừa lấy
                strCommand = "DELETE GiaoVien WHERE MaGiaoVien=@maGiaoVien";
                Database.Execute(strCommand, parameters);
                //Nạp lại bảng dữ liệu
                loadDgvGiaoVien();
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            //Lấy ra mã giáo viên ở dòng đang chọn
            int maGiaoVien = (int)dgvGiaoVien.CurrentRow.Cells["colMaGiaoVien"].Value;
            //Truyền mã giáo viên đó sang form sửa giáo viên
            FrmSuaGiaoVien form = new FrmSuaGiaoVien(maGiaoVien);
            //Hiển thị form sửa giáo viên
            form.ShowDialog();
            //Nạp lại bảng dữ liệu
            loadDgvGiaoVien();
        }
    }
}
