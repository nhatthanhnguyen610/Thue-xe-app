using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thue_xe_app.Model;
using static Thue_xe_app.Connect.ConnectString;


namespace Thue_xe_app
{
    public partial class ThueXe : Form
    {
        SqlConnection conn = new SqlConnection(getConnectString());
        DanhSachXeModel md = new DanhSachXeModel();
        int maKh;
        private void doiGia(int dv)
        {
            try
            {
                conn.Open();
                string sql = "select * from GiaThue where maDv = " + dv;
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            txtGia.Text = Convert.ToInt32(reader.GetValue(2)).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
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
        }

        private void comboDv_SelectedIndexChanged(object sender, EventArgs e)
        {
            doiGia(comboDv.SelectedIndex+1);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "insert into KhachHang ([tenKh],[cmnd],[diaChi],[sdt],[trangThai])" +
                    " values('" + txtTen.Text + "', '" + txtCmnd.Text + "','" + txtDiaChi.Text + "', '" + txtSdt.Text + "', '" + 0 + "' )";
                command.ExecuteNonQuery();

                string sql = "select top 1 maKh from KhachHang order by maKh desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                           maKh = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                }

                SqlCommand commandInsert = conn.CreateCommand();
                commandInsert.CommandText = "insert into HopDong  ([maXe],[maKh],[maDv],[ngayBd],[maNV],[trangThai]) " +
                    "values ('" + txtMaXe.Text + "', '" + maKh.ToString() + "','" + (comboDv.SelectedIndex+1).ToString() + "', '" + dateBD.Value.ToShortDateString() + "', '" + 1 + "', '" + 0 + "' )";
                commandInsert.ExecuteNonQuery();
                MessageBox.Show("Thuê thành công", "Thông báo", MessageBoxButtons.OK);

                SqlCommand commandUpdate = conn.CreateCommand();
                commandUpdate.CommandText = "update Xe SET [trangThai] = 1 where maXe = " + md.maXe;
                commandUpdate.ExecuteNonQuery();

                DanhSachXe danhSachXe = new DanhSachXe();          
                this.Hide();
                danhSachXe.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập thông tin không hợp lệ", "Cảnh báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhSachXe danhSachXe = new DanhSachXe();
            this.Hide();
            danhSachXe.Show();
            this.Close();
        }
    }
}
