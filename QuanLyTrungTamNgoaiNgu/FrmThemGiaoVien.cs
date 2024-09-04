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
    public partial class FrmThemGiaoVien : Form
    {
        private DataTable trinhDoGiaoViens = new DataTable();
        private void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        private void loadCbbBangCap()
        {
            cbbBangCap.DataSource = Database.Query("SELECT * FROM BangCap", new Dictionary<string, object>());
        }
        public FrmThemGiaoVien()
        {
            InitializeComponent();
            loadCbbNgoaiNgu();
            loadCbbBangCap();
            dgvTrinhDoGiaoVien.AutoGenerateColumns = false;
            trinhDoGiaoViens.Columns.Add("MaNgoaiNgu");
            trinhDoGiaoViens.Columns.Add("TenNgoaiNgu");
            trinhDoGiaoViens.Columns.Add("MaBangCap");
            trinhDoGiaoViens.Columns.Add("TenBangCap");
            trinhDoGiaoViens.Columns.Add("GhiChu");
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            erpMessage.Clear();
            for (int i = 0; i < trinhDoGiaoViens.Rows.Count; ++i)
                if (trinhDoGiaoViens.Rows[i]["MaNgoaiNgu"].ToString() == cbbNgoaiNgu.SelectedValue.ToString() && trinhDoGiaoViens.Rows[i]["MaBangCap"].ToString() == cbbBangCap.SelectedValue.ToString())
                {
                    erpMessage.SetError(cbbNgoaiNgu, "Ngoại ngữ và bằng cấp này đã được thêm");
                    erpMessage.SetError(cbbBangCap, "Ngoại ngữ và bằng cấp này đã được thêm");
                    return;
                }
            DataRow trinhDoGiaoVien = trinhDoGiaoViens.NewRow();
            trinhDoGiaoVien["MaNgoaiNgu"] = cbbNgoaiNgu.SelectedValue.ToString();
            trinhDoGiaoVien["TenNgoaiNgu"] = cbbNgoaiNgu.Text;
            trinhDoGiaoVien["MaBangCap"] = cbbBangCap.SelectedValue.ToString();
            trinhDoGiaoVien["TenBangCap"] = cbbBangCap.Text;
            trinhDoGiaoVien["GhiChu"] = tboGhiChu.Text;
            trinhDoGiaoViens.Rows.Add(trinhDoGiaoVien);
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
            btoXoa.Enabled = dgvTrinhDoGiaoVien.Rows.Count > 0;
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string strCommand = "INSERT GiaoVien (Ho,Ten,NgaySinh,GioiTinh,DiaChi,DienThoai,Email) VALUES (@ho,@ten,@ngaySinh,@gioiTinh,@diaChi,@dienThoai,@email)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ho", tboHo.Text);
            parameters.Add("@ten", tboTen.Text);
            parameters.Add("@ngaySinh", dtpNgaySinh.Value);
            if (chbGioiTinh.Checked == false)
                parameters.Add("@gioiTinh", null);
            else
                parameters.Add("@gioiTinh", rdbNam.Checked);
            parameters.Add("@diaChi", tboDiaChi.Text);
            parameters.Add("@dienThoai", tboDienThoai.Text);
            parameters.Add("@email", tboEmail.Text);
            Database.Execute(strCommand, parameters);
            int maGiaoVien = (int)Database.Query("SELECT MAX(MaGiaoVien) FROM GiaoVien", new Dictionary<string, object>()).Rows[0][0];
            strCommand = "INSERT TrinhDoGiaoVien VALUES(@maGiaoVien,@maNgoaiNgu,@maBangCap,@ghiChu)";
            for (int i = 0; i < trinhDoGiaoViens.Rows.Count; ++i)
            {
                parameters = new Dictionary<string, object>();
                parameters.Add("@maGiaoVien", maGiaoVien);
                parameters.Add("@maNgoaiNgu", trinhDoGiaoViens.Rows[i]["MaNgoaiNgu"]);
                parameters.Add("@maBangCap", trinhDoGiaoViens.Rows[i]["MaBangCap"]);
                parameters.Add("@ghiChu", trinhDoGiaoViens.Rows[i]["GhiChu"]);
                Database.Execute(strCommand, parameters);
            }
            MessageBox.Show("Đã thêm giáo viên thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            trinhDoGiaoViens.Rows.RemoveAt(dgvTrinhDoGiaoVien.CurrentRow.Index);
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
            btoXoa.Enabled = dgvTrinhDoGiaoVien.Rows.Count > 0;
        }

        private void chbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            grbGioiTinh.Enabled = chbGioiTinh.Checked;
        }

        private void btoNgoaiNgu_Click(object sender, EventArgs e)
        {
            FrmQuanLyNgoaiNgu form = new FrmQuanLyNgoaiNgu();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            loadCbbNgoaiNgu();
        }

        private void btoBangCap_Click(object sender, EventArgs e)
        {
            FrmQuanLyBangCap form = new FrmQuanLyBangCap();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            loadCbbBangCap();
        }
    }
}
