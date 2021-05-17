using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using static Thue_xe_app.Connect.ConnectString;

namespace Thue_xe_app
{
    public partial class HoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = getConnectString();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public int maHd, maKh, maDv, tong;
        public HoaDon(int maHd)
        {
            InitializeComponent();
            this.maHd = maHd;
        }


        private void HoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select KhachHang.maKh, KhachHang.tenKh, GiaThue.maDv, Xe.tenXe, GiaThue.gia, HopDong.ngayBd " +
                "from HopDong " +
                "inner join KhachHang on HopDong.maKh = KhachHang.maKh " +
                "inner join GiaThue on HopDong.maDv = GiaThue.maDv " +
                " inner join Xe on HopDong.maXe = Xe.maXe " +
                "where HopDong.maHd = '" + maHd + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        maKh = Convert.ToInt32(reader.GetValue(0));
                        maDv = Convert.ToInt32(reader.GetValue(2));
                    }
                }
            }

            txt_TenKhachHang.DataBindings.Add("text", table, "tenKh");
            txt_TenXe.DataBindings.Add("text", table, "tenXe");
            txt_Gia.DataBindings.Add("text", table, "gia");
            txt_NgayBatDau.DataBindings.Add("text", table, "ngayBd");
            txt_NgayKetThuc.Text = DateTime.Now.ToShortDateString();
            tinhThoiGian();
            tongTien();

        }

        public void tinhThoiGian()
        {
            TimeSpan ts;
            DateTime ngayBatDau = DateTime.Parse(txt_NgayBatDau.Text);
            DateTime ngayKetThuc = DateTime.Parse(txt_NgayKetThuc.Text);

            ts = ngayKetThuc - ngayBatDau;
            txt_ThoiGianSuDung.Text = Convert.ToString(ts.TotalDays);
        }

        public void tongTien()
        {
            int gia = int.Parse(txt_Gia.Text);
            int thoiGian = int.Parse(txt_ThoiGianSuDung.Text);
            tong = gia * thoiGian;
            txt_TongTien.Text = String.Format(new CultureInfo("en-US"), "{0:c}", gia * thoiGian);
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show();
            this.Close();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            addThanhToan();
            update();
            this.Hide();
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show();
            this.Close();
        }

        public void addThanhToan()
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into ThanhToan values ('" + maKh + "', '" + maDv + "','" + txt_NgayBatDau.Text + "', '" + txt_NgayKetThuc.Text + "', '" + txt_ThoiGianSuDung.Text + "','" + tong + "', '" + 1 + "' )";
            command.ExecuteNonQuery();
        }
        public void update()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "update HopDong set trangThai = 1 where maHd= '" + maHd + "'";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất hóa đơn thất bại");
            }
        }
    }
}
