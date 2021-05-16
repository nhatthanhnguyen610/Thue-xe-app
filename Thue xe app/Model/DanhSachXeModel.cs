using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thue_xe_app.Model
{
    public class DanhSachXeModel
    {
        public DanhSachXeModel(int maXe, int bienSo,string tenXe, string imageUrl, bool trangThai)
        {
            this.maXe = maXe;
            this.bienSo = bienSo;
            this.tenXe = tenXe;
            this.imageUrl = imageUrl;
            this.trangThai = trangThai;
        }
        public int maXe { get; set; }
        public int bienSo { get; set; }
        public string tenXe { get; set; }
        public string imageUrl { get; set; }
        public bool trangThai { get; set; }
        
    }
   
}
