using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom5.Menu
{
    public partial class MenuNhanVien : Form
    {
        public MenuNhanVien()
        {
            InitializeComponent();
        }
        private void IMBanHang_Click(object sender, EventArgs e)
        {
            var frm = new BanHang();
            frm.MdiParent = this;
            frm.Show();
        }

       

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new QuanLy.QLKhachHang();
            frm.MdiParent = this;
            frm.Show();
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

        private void IMDSSanPham_Click(object sender, EventArgs e)
        {
            var frm = new San_Pham.DSSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form_HoaDon();
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
            Form frm = new MenuQuanLy();
            frm.Show();
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
