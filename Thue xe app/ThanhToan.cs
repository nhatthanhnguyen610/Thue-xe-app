using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Thue_xe_app.Connect.ConnectString;

namespace Thue_xe_app
{
    public partial class ThanhToan : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = getConnectString();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public int MaHd;

        public ThanhToan()
        {
            InitializeComponent();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select HopDong.maHd,KhachHang.tenKh, Xe.tenXe, GiaThue.gia, HopDong.ngayBd from HopDong " +
                "inner join KhachHang on HopDong.maKh = KhachHang.maKh " +
                "inner join GiaThue on HopDong.maDv = GiaThue.maDv " +
                "inner join Xe on HopDong.maXe = Xe.maXe " +
                "where HopDong.trangThai = 0";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView_ThanhToan.DataSource = table;
            dataGridView_ThanhToan.Columns["maHd"].Width = 40;
            loadButton();
        }

        public void loadDatabyKeyword()
        {
            command = connection.CreateCommand();
            command.CommandText = "select HopDong.maHd,KhachHang.tenKh, Xe.tenXe, GiaThue.gia, HopDong.ngayBd from HopDong " +
                "inner join KhachHang on HopDong.maKh = KhachHang.maKh " +
                "inner join GiaThue on HopDong.maDv = GiaThue.maDv " +
                "inner join Xe on HopDong.maXe = Xe.maXe " +
                "where tenKh like '%" + txt_TimKiem.Text + "%'" + "and HopDong.trangThai = 0";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView_ThanhToan.DataSource = table;
            dataGridView_ThanhToan.Columns["maHd"].Width = 40;
            dataGridView_ThanhToan.Columns[5].Visible = false;
            loadButton();
        }


        private void ThanhToan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        public void loadButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Thanh Toán";
            buttonColumn.HeaderText = "Thanh toán";
            buttonColumn.Name = "Thanh Toán";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle = FlatStyle.Standard;
            buttonColumn.CellTemplate.Style.BackColor = Color.Honeydew;
            buttonColumn.Width = 100;
            dataGridView_ThanhToan.Columns.Insert(5, buttonColumn);



        }

        private void dataGridView_ThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaHd = int.Parse(dataGridView_ThanhToan.Rows[dataGridView_ThanhToan.CurrentRow.Index].Cells[0].Value.ToString());
            int i;
            i = dataGridView_ThanhToan.CurrentCell.ColumnIndex;
            if (i == 5)
            {
                HoaDon hoaDon = new HoaDon(MaHd);
                hoaDon.Show();
            }
        }



        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            loadDatabyKeyword();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            loadDatabyKeyword();
        }
    }
}
