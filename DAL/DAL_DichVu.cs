using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DTO;

namespace DAL
{
    public class DAL_DichVu : DataProvider
    {
        public DAL_DichVu() { }

        public List<DTO_DichVu> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.DichVus.Select(c => new DTO_DichVu
                {
                    MaDichVu = c.MaDichVu,
                    TenDichVu = c.TenDichVu,
                    HinhAnh = c.HinhAnh,
                    MoTa=c.MoTa,
                    MaLoaiDichVu= c.MaLoaiDichVu,
                    DieuKienBanToiDa=c.DieuKienBanToiDa,
                    DieuKienBanToiThieu=c.DieuKienBanToiThieu,
                    GiaGiam30=(float)c.GiaGiam30,
                    GiaLe=(float)c.GiaLe,
                    GiaTronGoi=(float)c.GiaTronGoi
                }).ToList();
            }
        }
        public DTO_DichVu GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVus.SingleOrDefault(c => c.MaDichVu == ma);
                if (item != null)
                {
                    return new DTO_DichVu
                    {
                        MaDichVu = item.MaDichVu,
                        TenDichVu = item.TenDichVu,
                        HinhAnh = item.HinhAnh,
                        MoTa = item.MoTa,
                        MaLoaiDichVu = item.MaLoaiDichVu,
                        DieuKienBanToiDa = item.DieuKienBanToiDa,
                        DieuKienBanToiThieu = item.DieuKienBanToiThieu,
                        GiaGiam30 = (float)item.GiaGiam30,
                        GiaLe = (float)item.GiaLe,
                        GiaTronGoi = (float)item.GiaTronGoi
                    };
                }
                return null;
            }
        }
        public void Add(DTO_DichVu dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new DichVu
                {
                    MaDichVu = dto.MaDichVu,
                    TenDichVu = dto.TenDichVu,
                    HinhAnh = dto.HinhAnh,
                    MoTa = dto.MoTa,
                    MaLoaiDichVu = dto.MaLoaiDichVu,
                    DieuKienBanToiDa = dto.DieuKienBanToiDa,
                    DieuKienBanToiThieu = dto.DieuKienBanToiThieu,
                    GiaGiam30 = (float)dto.GiaGiam30,
                    GiaLe = (float)dto.GiaLe,
                    GiaTronGoi = (float)dto.GiaTronGoi
                };

                context.DichVus.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_DichVu dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVus.SingleOrDefault(c => c.MaDichVu == dto.MaDichVu);
                if (item != null)
                {
                    item.TenDichVu = dto.TenDichVu;
                    item.HinhAnh = dto.HinhAnh;
                    item.MaLoaiDichVu = dto.MaLoaiDichVu;
                    item.DieuKienBanToiDa = dto.DieuKienBanToiDa;
                    item.DieuKienBanToiThieu = dto.DieuKienBanToiThieu;
                    item.GiaGiam30 = (float)dto.GiaGiam30;
                    item.GiaLe = (float)dto.GiaLe;
                    item.GiaTronGoi = (float)dto.GiaTronGoi;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVus.SingleOrDefault(c => c.MaDichVu == ma);
                if (item != null)
                {
                    context.DichVus.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
