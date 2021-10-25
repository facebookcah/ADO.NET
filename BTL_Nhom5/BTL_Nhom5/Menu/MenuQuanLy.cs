using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom5
{
    public partial class MenuQuanLy : Form
    {
        public MenuQuanLy()
        {
            InitializeComponent();
        }

        private void IMBanHang_Click(object sender, EventArgs e)
        {
            var frm = new BanHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void IMDSSP_Click(object sender, EventArgs e)
        {
            var frm = new San_Pham.DSSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new QuanLy.QLKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }
        private void MenuQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void MenuQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) Application.Exit();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormPhieuNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new NhaCC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new QuanLyTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new QuanLyNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormPhieuThu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frm = new FormPhieuChi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void IMQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form_HoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sổQuỹToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormSoQuy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoTàiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormBaoCaoTC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormBaoCaoTK();
            frm.MdiParent = this;
            frm.Show();
        }

        private void IMTrangChu_Click(object sender, EventArgs e)
        {
            MenuQuanLy_Load(sender,e);
        }

        private void IMDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_GT();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
