using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thue_xe_app.Model;

namespace Thue_xe_app
{
    public partial class ThueXe : Form
    {
        DanhSachXeModel md = new DanhSachXeModel();
        public ThueXe(DanhSachXeModel model)
        {
            InitializeComponent();
            md = model;
        }

        private void ThueXe_Load(object sender, EventArgs e)
        {
            txtMaXe.Text = md.maXe.ToString();
            txtBienSo.Text = md.bienSo.ToString();
            txtTenXe.Text = md.tenXe;
            txtGia.Text = "100000";
        }
    }
}
