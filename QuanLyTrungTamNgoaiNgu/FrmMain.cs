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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mniNgoaiNgu_Click(object sender, EventArgs e)
        {
            FrmQuanLyNgoaiNgu form = new FrmQuanLyNgoaiNgu();
            for (int i = 0; i <  this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniBangCap_Click(object sender, EventArgs e)
        {
            FrmQuanLyBangCap form = new FrmQuanLyBangCap();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniGiaoVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyGiaoVien form = new FrmQuanLyGiaoVien();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }
    }
}
