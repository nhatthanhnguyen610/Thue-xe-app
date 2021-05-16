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
    public partial class DanhSachNguoiThue : Form
    {
        public DanhSachNguoiThue()
        {
            InitializeComponent();
        }

        String idNguoiThue;
        SqlConnection connection;
        SqlCommand command;
        string str = getConnectString();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from KhachHang where trangThai <> 1";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewNguoiThue.DataSource = table;
            dataGridViewNguoiThue.Columns[5].Visible = false
        }

        public void loadDatabyKeyword()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from KhachHang where tenKh like '%" + txt_TimKiemNguoiThue.Text + "%'" + "and trangThai <> 1";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewNguoiThue.DataSource = table;
        }


        private void btnVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }

        private void DanhSachNguoiThue_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }


        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            loadDatabyKeyword();
        }

        private void bt_HienThiTatCa_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void txt_TimKiemNguoiThue_TextChanged(object sender, EventArgs e)
        {
            loadDatabyKeyword();
        }

        private void dataGridViewNguoiThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewNguoiThue.CurrentRow.Index;
            idNguoiThue = dataGridViewNguoiThue.Rows[i].Cells[0].Value.ToString();
            txt_TenNguoiThue.Text = dataGridViewNguoiThue.Rows[i].Cells[1].Value.ToString();
            txt_CMND.Text = dataGridViewNguoiThue.Rows[i].Cells[2].Value.ToString();
            txt_DiaChi.Text = dataGridViewNguoiThue.Rows[i].Cells[3].Value.ToString();
            txt_SDT.Text = dataGridViewNguoiThue.Rows[i].Cells[4].Value.ToString();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Update KhachHang set trangThai= '" + 1 + "' where maKh='" + idNguoiThue + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            int sdt = int.Parse(txt_SDT.Text);
            command.CommandText = "update KhachHang set tenKh='" + txt_TenNguoiThue.Text + "', cmnd='" + txt_CMND.Text + "', diaChi='" + txt_DiaChi.Text + "', sdt='" + sdt + "' where maKh='" + idNguoiThue + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
