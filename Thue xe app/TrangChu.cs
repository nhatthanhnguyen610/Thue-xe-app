﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thue_xe_app
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có chắc muốn đăng xuất", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            if (DialogResult.Cancel == DR)
            {
                
            }
        }

        private void btnDanhSachXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachXe danhSachXe = new DanhSachXe();
            danhSachXe.Show();
        }

        private void btnDanhSachNguoiThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachNguoiThue danhSachNguoiThue = new DanhSachNguoiThue();
            danhSachNguoiThue.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe thongKe = new ThongKe();
            thongKe.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                Application.Exit();
            }
            if (DialogResult.Cancel == DR)
            {

            }
        }

    }
}
