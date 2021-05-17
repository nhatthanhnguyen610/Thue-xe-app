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
using static Thue_xe_app.Connect.ConnectString;

namespace Thue_xe_app
{
    public partial class ThongKe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = getConnectString();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        int thang, nam, doanhThu;

        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }

        private void bt_ThongKe_Click(object sender, EventArgs e)
        {
            if (txt_Thang.Text == "" || txt_Nam.Text == "")
            {
                MessageBox.Show("Nhập thiếu dữ liệu");
            }
            else if (int.Parse(txt_Nam.Text) <= DateTime.Now.Year)
            {
                if (int.Parse(txt_Thang.Text) <= DateTime.Now.Month)
                {
                    thang = int.Parse(txt_Thang.Text);
                    nam = int.Parse(txt_Nam.Text);
                    loadData();
                    tongTien();
                    txt_DoanhThu.Text = doanhThu.ToString();
                }
                else
                {
                    MessageBox.Show("Nhập sai thời gian tháng");
                }

            }
            else
            {
                MessageBox.Show("Nhập sai thời gian năm");
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            chart();
        }

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select SUM(ThanhToan.tongTien) from ThanhToan " +
                "where DATEPART(M, ThanhToan.ngayKt) = '" + thang + "' and DATEPART(YEAR, ThanhToan.ngayKt) =  '" + nam + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

        }

        private void tongTien()
        {
            try
            {
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            doanhThu = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tháng này không có doanh thu");
            }
        }

        private void chart()
        {
            if (txt_DoanhThu.Text != "")
            {
                chart_ThongKe.Series["Doanh thu"].Points.AddXY(txt_Thang.Text + "/" + txt_Nam.Text, doanhThu);
            }
        }
    }
}
