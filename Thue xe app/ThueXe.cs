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
    }
}
