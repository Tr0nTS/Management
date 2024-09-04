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
    public partial class FrmSuaGiaoVien : Form
    {
        private int maGiaoVien;

        private void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        private void loadCbbBangCap()
        {
            cbbBangCap.DataSource = Database.Query("SELECT * FROM BangCap", new Dictionary<string, object>());
        }
        private void loadForm()
        {
            //Lấy ra các thông tin của giáo viên dựa vào mã giáo viên
            string strQuery = "SELECT * FROM GiaoVien WHERE MaGiaoVien=@maGiaoVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            DataRow giaoVien = Database.Query(strQuery, parameters).Rows[0];
            //Nạp các thông tin lấy được lên form
            tboMaGiaoVien.Text = giaoVien["MaGiaoVien"].ToString();
            tboHo.Text = giaoVien["Ho"].ToString();
            tboTen.Text = giaoVien["Ten"].ToString();
            dtpNgaySinh.Value = DateTime.Parse(giaoVien["NgaySinh"].ToString());
            if (giaoVien["GioiTinh"] == null)
                chbGioiTinh.Checked = false;
            else if (giaoVien["GioiTinh"].ToString().ToLower() == "true")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
            tboDiaChi.Text = giaoVien["DiaChi"].ToString();
            tboDienThoai.Text = giaoVien["DienThoai"].ToString();
            tboEmail.Text = giaoVien["Email"].ToString();
            //Lấy ra danh sách các trình độ ngoại ngữ ứng với mã giáo viên
            strQuery = "SELECT TenNgoaiNgu,TenBangCap,GhiChu"
                + " FROM TrinhDoGiaoVien"
                + " INNER JOIN NgoaiNgu ON TrinhDoGiaoVien.MaNgoaiNgu = NgoaiNgu.MaNgoaiNgu"
                + " INNER JOIN BangCap ON TrinhDoGiaoVien.MaBangCap = BangCap.MaBangCap"
                + " WHERE MaGiaoVien=@maGiaoVien";
            DataTable trinhDoGiaoViens = Database.Query(strQuery, parameters);
            //Đẩy dữ liệu lên data gridview
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
        }
        public FrmSuaGiaoVien(int maGiaoVien)
        {
            InitializeComponent();
            loadCbbNgoaiNgu();
            loadCbbBangCap();
            //Nhận mã giáo viên được truyền vào
            this.maGiaoVien = maGiaoVien;
            //Dựa vào mã giáo viên nhận được, lấy ra các thông tin của giáo viên và nạp lên form
            loadForm();
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string strCommand = "UPDATE GiaoVien SET Ho=@ho,Ten=@ten,NgaySinh=@ngaySinh,GioiTinh=@gioiTinh,DiaChi=@diaChi,DienThoai=@dienThoai,Email=@email WHERE MaGiaoVien=@maGiaoVien";
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
            parameters.Add("@maGiaoVien", maGiaoVien);
            Database.Execute(strCommand, parameters);
            MessageBox.Show("Đã cập nhật thông tin giáo viên thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
