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
using static Thue_xe_app.Connect.ConnectString;
using Thue_xe_app.Model;
using System.Data.Common;

namespace Thue_xe_app
{

    public partial class DanhSachXe : Form
    {
        SqlConnection conn = new SqlConnection(getConnectString());
        List<DanhSachXeModel> danhSachXeModels = new List<DanhSachXeModel>();
        int soThuTu;
        int tongSoXe;

        public DanhSachXe()
        {
            InitializeComponent();
            
        }

        private List<DanhSachXeModel> getdanhSachXeModels(string kw)
        {
            tongSoXe = 0;
            List<DanhSachXeModel> danhSachXeModels = new List<DanhSachXeModel>();
            conn.Open();
            string sql = "select * from Xe where tenXe like '%" + kw + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        
                        int maXe = Convert.ToInt32(reader.GetValue(0));
                        int bienSo = Convert.ToInt32(reader.GetValue(1));
                        string tenXe = reader.GetString(2);
                        string imageUrl;
                        try
                        {
                            imageUrl = reader.GetString(3);
                        }
                        catch(Exception ex)
                        {
                            imageUrl = "";
                        }
                        bool trangThai = Convert.ToBoolean(reader.GetValue(4));
                        DanhSachXeModel temp = new DanhSachXeModel(maXe, bienSo, tenXe, imageUrl, trangThai);
                        danhSachXeModels.Add(temp);
                        tongSoXe++;
                    }
                }
            }
            conn.Close();
            return danhSachXeModels;
        }

        private void loadXe(int soThuTu)
        {
            try
            {
                picXe.Image = Image.FromFile(danhSachXeModels[soThuTu].imageUrl);
            }
            catch (Exception ex)
            {

            }
            lbMaXe.Text = "Mã xe: " + danhSachXeModels[soThuTu].maXe.ToString();
            lbTenXe.Text = "Tên xe: " + danhSachXeModels[soThuTu].tenXe;
            lbBienSo.Text = "Biển số: " + danhSachXeModels[soThuTu].bienSo.ToString();
            lbTrangThai.ForeColor = lbTrangThai.BackColor = !danhSachXeModels[soThuTu].trangThai ? Color.Green : Color.Red;
            btnThueXe.Enabled = !danhSachXeModels[soThuTu].trangThai;
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text;
            danhSachXeModels = getdanhSachXeModels(kw);
            soThuTu = 0;
            loadXe(soThuTu);
        }

        private void DanhSachXe_Load(object sender, EventArgs e)
        {
            danhSachXeModels = getdanhSachXeModels("");
            soThuTu = 0;
            
            loadXe(soThuTu);
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            soThuTu--;
            if (soThuTu < 0)
                soThuTu = tongSoXe;
            loadXe(soThuTu);
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            soThuTu++;
            if (soThuTu > tongSoXe - 1)
                soThuTu = 0;
            loadXe(soThuTu);
        }

        private void btnThueXe_Click(object sender, EventArgs e)
        {
            
            ThueXe login = new ThueXe(danhSachXeModels[soThuTu]);
            login.Show();
        }
    }
}
