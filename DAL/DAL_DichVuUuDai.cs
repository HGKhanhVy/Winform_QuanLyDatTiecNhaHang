using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DichVuUuDai : DataProvider
    {
        public DAL_DichVuUuDai() { }

        public List<DTO_DichVuUuDai> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.DichVuUuDais.Select(c => new DTO_DichVuUuDai
                {
                    MaDichVuUuDai = c.MaDichVuUuDai,
                    TenDichVu = c.TenDichVu,
                    DieuKienBanToiThieu = c.DieuKienBanToiThieu,
                    DieuKienBanToiDa=c.DieuKienBanToiDa,
                    MoTa = c.MoTa,
                    HinhAnh = c.HinhAnh,
                    MaDichVu = c.MaDichVu,
                }).ToList();
            }
        }
        public DTO_DichVuUuDai GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVuUuDais.SingleOrDefault(c => c.MaDichVuUuDai == ma);
                if (item != null)
                {
                    return new DTO_DichVuUuDai
                    {
                        MaDichVuUuDai = item.MaDichVuUuDai,
                        TenDichVu = item.TenDichVu,
                        DieuKienBanToiDa = item.DieuKienBanToiDa,
                        DieuKienBanToiThieu=item.DieuKienBanToiThieu,
                        MoTa = item.MoTa,
                        HinhAnh = item.HinhAnh,
                        MaDichVu = item.MaDichVu,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_DichVuUuDai dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new DichVuUuDai
                {
                    MaDichVuUuDai = dto.MaDichVuUuDai,
                    TenDichVu = dto.TenDichVu,
                    DieuKienBanToiThieu = dto.DieuKienBanToiThieu,
                    DieuKienBanToiDa=dto.DieuKienBanToiDa,
                    MoTa = dto.MoTa,
                    HinhAnh = dto.HinhAnh,
                    MaDichVu = dto.MaDichVu,
                };
                context.DichVuUuDais.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_DichVuUuDai dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVuUuDais.SingleOrDefault(c => c.MaDichVuUuDai == dto.MaDichVuUuDai);
                if (item != null)
                {
                    item.TenDichVu = dto.TenDichVu;
                    item.DieuKienBanToiDa = dto.DieuKienBanToiDa;
                    item.DieuKienBanToiThieu = dto.DieuKienBanToiThieu;
                    item.MoTa = dto.MoTa;
                    item.HinhAnh = dto.HinhAnh;
                    item.MaDichVu = dto.MaDichVu;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DichVuUuDais.SingleOrDefault(c => c.MaDichVuUuDai == ma);
                if (item != null)
                {
                    context.DichVuUuDais.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
