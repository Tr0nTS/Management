using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FrmQuanLyNgoaiNgu : Form
    {
        public FrmQuanLyNgoaiNgu()
        {
            InitializeComponent();
        }

        private bool checkForm()
        {
            eprError.Clear();
            bool ketQua = true;
            if (tboMaNgoaiNgu.Text.Trim() == "")
            {
                //MessageBox.Show("Chưa điền mã ngoại ngữ");
                eprError.SetError(tboMaNgoaiNgu, "Chưa điền mã ngoại ngữ");
                ketQua = false;
            }
            if (tboMaNgoaiNgu.Text.Length > 3)
            {
                //MessageBox.Show("Mã ngoại ngữ không đúng định dạng");
                eprError.SetError(tboMaNgoaiNgu, "Mã ngoại ngữ không đúng định dạng");
                ketQua = false;
            }
            if (tboTenNgoaiNgu.Text.Trim() == "")
            {
                //MessageBox.Show("Chưa điền tên ngoại ngữ");
                eprError.SetError(tboTenNgoaiNgu, "Chưa điền tên ngoại ngữ");
                ketQua = false;
            }
            if (tboTenNgoaiNgu.Text.Length > 30)
            {
                //MessageBox.Show("Tên ngoại ngữ không đúng định dạng");
                eprError.SetError(tboTenNgoaiNgu, "Tên ngoại ngữ không đúng định dạng");
                ketQua = false;
            }
            if (ketQua == false)
                lblStatus.Text = "Thông báo: dữ liệu không đúng định dạng";
            return ketQua;
          
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            eprError.Clear();
            if (checkForm() == false)
                return;
            string strCommand = "EXEC spThemNgoaiNgu @maNgoaiNgu,@tenNgoaiNgu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
            parameters.Add("@tenNgoaiNgu", tboTenNgoaiNgu.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                loadDgvNgoaiNgu();
                lblStatus.Text = "Thông báo: Thêm dữ liệu thành công";
            }
            catch(Exception ex)
            {
                if (ex.Message == "Trùng mã ngoại ngữ")
                    eprError.SetError(tboMaNgoaiNgu, ex.Message);
                else if (ex.Message == "Trùng tên ngoại ngữ")
                    eprError.SetError(tboTenNgoaiNgu, ex.Message);
                lblStatus.Text = "Thông báo: " + ex.Message;
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmQuanLyNgoaiNgu_Load(object sender, EventArgs e)
        {
            loadDgvNgoaiNgu();
        }

        private void loadDgvNgoaiNgu()
        {
            if (chbTimKiem.Checked == false)
            {
                string strQuery = "SELECT * FROM NgoaiNgu";
                DataTable table = Database.Query(strQuery, new Dictionary<string, object>());
                dgvNgoaiNgu.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
            else
            {
                string strQuery = "SELECT * FROM dbo.ufTimNgoaiNgu(@maNgoaiNgu,@tenNgoaiNgu)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (chbMaNgoaiNgu.Checked)
                    parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
                else
                    parameters.Add("@maNgoaiNgu", "");
                if (chbTenNgoaiNgu.Checked)
                    parameters.Add("@tenNgoaiNgu", tboTenNgoaiNgu.Text);
                else
                    parameters.Add("@tenNgoaiNgu", "");
                DataTable table = Database.Query(strQuery, parameters);
                dgvNgoaiNgu.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
        }

        private void btoThem_MouseHover(object sender, EventArgs e)
        {
            btoThem.Text = "THÊM";
        }

        private void btoThem_MouseLeave(object sender, EventArgs e)
        {
            btoThem.Text = "Thêm";
        }

        private void dgvNgoaiNgu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tboMaNgoaiNgu.Text = dgvNgoaiNgu.Rows[e.RowIndex].Cells["colMaNgoaiNgu"].Value.ToString();
                tboTenNgoaiNgu.Text = dgvNgoaiNgu.Rows[e.RowIndex].Cells["colTenNgoaiNgu"].Value.ToString();
                string strQuery = "SELECT * FROM dbo.ufTimGiaoVienTheoNgoaiNgu(@maNgoaiNgu)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
                DataTable giaoViens = Database.Query(strQuery, parameters);
                //Nạp dữ liệu lên treeview
                trvGiaoVien.Nodes.Clear();
                TreeNode node = new TreeNode("Giáo viên biết ngoại ngữ");
                for (int i = 0; i < giaoViens.Rows.Count; ++i)
                    node.Nodes.Add(giaoViens.Rows[i]["MaGiaoVien"].ToString() + " - " + giaoViens.Rows[i]["Ho"].ToString() + " " + giaoViens.Rows[i]["Ten"].ToString());
                node.Expand();
                trvGiaoVien.Nodes.Add(node);
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            if (checkForm() == false)
                return;
            string strQuery = "SELECT * FROM NgoaiNgu WHERE MaNgoaiNgu<>@maNgoaiNgu AND TenNgoaiNgu=@tenNgoaiNgu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNgoaiNgu", dgvNgoaiNgu.CurrentRow.Cells["colMaNgoaiNgu"].Value.ToString());
            parameters.Add("@tenNgoaiNgu", tboTenNgoaiNgu.Text);
            DataTable table = Database.Query(strQuery, parameters);
            if (table.Rows.Count > 0)
            {
                eprError.SetError(tboTenNgoaiNgu, "Trùng tên ngoại ngữ");
                lblStatus.Text = "Thông báo: Trùng dữ liệu";
                return;
            }
            string strCommand = "UPDATE NgoaiNgu SET TenNgoaiNgu=@tenNgoaiNgu WHERE MaNgoaiNgu=@maNgoaiNgu";
            Database.Execute(strCommand, parameters);
            loadDgvNgoaiNgu();
            lblStatus.Text = "Thông báo: Sửa dữ liệu thành công";
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spXoaNgoaiNgu @maNgoaiNgu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNgoaiNgu", dgvNgoaiNgu.CurrentRow.Cells["colMaNgoaiNgu"].Value.ToString());
            try
            {
                Database.Execute(strCommand, parameters);
                loadDgvNgoaiNgu();
                lblStatus.Text = "Thông báo: Xóa dữ liệu thành công";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Thông báo: " + ex.Message;
            }
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            btoTimKiem.Enabled = chbTimKiem.Checked;
            loadDgvNgoaiNgu();
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvNgoaiNgu();
        }
    }
}
