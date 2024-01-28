using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DichVuTinhPhi:DataProvider
    {
        public DAL_DichVuTinhPhi() { }

        public List<DTO_DichVuTinhPhi> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.DichVuTinhPhis.Select(c => new DTO_DichVuTinhPhi
                {
                    MaDichVuTinhPhi = c.MaDichVuTinhPhi,
                    TenDichVu = c.TenDichVu,
                    MoTa = c.MoTa,
                    HinhAnh = c.HinhAnh,
                    GiaTronGoi = (float)c.GiaTronGoi,
                    MaDichVu = c.MaDichVu,
                    DieuKienBanToiThieu=c.DieuKienBanToiThieu,
                    DieuKienBanToiDa=c.DieuKienBanToiDa,
                    GiaGiam30=(float)c.GiaGiam30,
                    GiaLe=(float)c.GiaLe,
                }).ToList();
            }
        }
        public DTO_DichVuTinhPhi GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVuTinhPhis.SingleOrDefault(c => c.MaDichVuTinhPhi == ma);
                if (item != null)
                {
                    return new DTO_DichVuTinhPhi
                    {
                        MaDichVuTinhPhi = item.MaDichVuTinhPhi,
                        TenDichVu = item.TenDichVu,
                        MoTa = item.MoTa,
                        HinhAnh = item.HinhAnh,
                        GiaTronGoi = (float)item.GiaTronGoi,
                        MaDichVu = item.MaDichVu,
                        DieuKienBanToiDa = item.DieuKienBanToiDa,
                        DieuKienBanToiThieu=item.DieuKienBanToiThieu,
                        GiaGiam30 = (float)item.GiaGiam30,
                        GiaLe = (float)item.GiaLe,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_DichVuTinhPhi dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new DichVuTinhPhi
                {
                    MaDichVuTinhPhi = dto.MaDichVuTinhPhi,
                    TenDichVu = dto.TenDichVu,
                    MoTa = dto.MoTa,
                    HinhAnh = dto.HinhAnh,
                    GiaTronGoi = (float)dto.GiaTronGoi,
                    MaDichVu = dto.MaDichVu,
                    DieuKienBanToiThieu = dto.DieuKienBanToiThieu,
                    DieuKienBanToiDa = dto.DieuKienBanToiDa,
                    GiaGiam30 = (float)dto.GiaGiam30,
                    GiaLe = (float)dto.GiaLe,
                };

                context.DichVuTinhPhis.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_DichVuTinhPhi dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVuTinhPhis.SingleOrDefault(c => c.MaDichVuTinhPhi == dto.MaDichVuTinhPhi);
                if (item != null)
                {
                    item.TenDichVu = dto.TenDichVu;
                    item.MoTa = dto.MoTa;
                    item.HinhAnh = dto.HinhAnh;
                    item.GiaTronGoi = (float)dto.GiaTronGoi;
                    item.MaDichVu = dto.MaDichVu;
                    item.DieuKienBanToiDa = dto.DieuKienBanToiDa;
                    item.DieuKienBanToiThieu = dto.DieuKienBanToiThieu;
                    item.GiaGiam30 = (float)dto.GiaGiam30;
                    item.GiaLe = (float)dto.GiaLe;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVuTinhPhis.SingleOrDefault(c => c.MaDichVuTinhPhi == ma);
                if (item != null)
                {
                    context.DichVuTinhPhis.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
