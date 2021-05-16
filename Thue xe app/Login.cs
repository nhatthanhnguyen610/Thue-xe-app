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
namespace Thue_xe_app
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        //       SqlConnection conn = new SqlConnection(@"Data Source=192.168.1.5,1433;Initial Catalog=ThueXe;User ID=sa;Password=123123");
        SqlConnection conn = new SqlConnection(getConnectString());
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string username = txtUser.Text;
                string password = txtPass.Text;
                string sql = "select * from NhanVien where userName='" + username + "' and passWord='" + password+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    TrangChu trangChu = new TrangChu();
                    trangChu.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
            }
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
