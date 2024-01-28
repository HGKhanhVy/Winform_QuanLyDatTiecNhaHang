using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DichVu
    {
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public string MaLoaiDichVu { get; set; }
        public int DieuKienBanToiThieu { get; set; }
        public int DieuKienBanToiDa { get; set; }
        public float GiaGiam30 { get; set; }
        public float GiaLe { get; set; }
        public float GiaTronGoi { get; set; }
    }
}
