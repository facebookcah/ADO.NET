using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BUS;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom5
{
    public partial class DialogThemDH : Form
    {
        Bus_BanHang bus = new Bus_BanHang();
        DataTable dt = null;
        public DialogThemDH()
        {
            InitializeComponent();
        }

        private void DialogThemDH_Load(object sender, EventArgs e)
        {
            load_cbKH();
            load_cbNV();
            load_cbHTTT();
        }

        public void load_cbKH()
        {
            dt = new DataTable();
            dt = bus.getKhachHang();
            cb_KH.DataSource = dt;
            cb_KH.DisplayMember = "HoTen";
            cb_KH.ValueMember = "MaKH";
        }
        public void load_cbNV()
        {
            dt = new DataTable();
            dt = bus.getNhanVien();
            cb_NV.DataSource = dt;
            cb_NV.DisplayMember = "HoTen";
            cb_NV.ValueMember = "MaNV";
        }
        public void load_cbHTTT()
        {
            dt = new DataTable();
            dt = bus.getHTTT();
            cbHTTT.DataSource = dt;
            cbHTTT.DisplayMember = "TenHTTT";
            cbHTTT.ValueMember = "MaHTTT";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDH.TextLength > 0)
                {
                    bus.insertHoaDon(txtMaDH.Text, cb_KH.SelectedValue.ToString().Trim(), cb_NV.SelectedValue.ToString().Trim(),cbHTTT.SelectedValue.ToString().Trim());
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập MaHD");
                }
            }
            catch
            {
                MessageBox.Show("MaHD đã tồn tại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            var frm = new QuanLy.ThemKhachHang();
            frm.ShowDialog();
            load_cbKH();
        }
    }
}
