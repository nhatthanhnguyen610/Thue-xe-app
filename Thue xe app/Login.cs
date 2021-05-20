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
using System.Data.Common;
using Thue_xe_app.ExportDocument;

namespace Thue_xe_app
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
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
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            Constants.username = reader.GetString(1);
                            Constants.isAdmin = Convert.ToBoolean(reader.GetValue(3));
                        }
                        this.Hide();
                        TrangChu trangChu = new TrangChu();
                        trangChu.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    }
                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
            }
            finally
            {
                conn.Close();
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
