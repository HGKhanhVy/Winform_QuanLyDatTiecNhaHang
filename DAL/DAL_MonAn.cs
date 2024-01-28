using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MonAn : DataProvider
    {
        public DAL_MonAn() { }

        public List<DTO_MonAn> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.MonAns.Select(c => new DTO_MonAn
                {
                    MaMonAn = c.MaMonAn,
                    TenMonAn = c.TenMonAn,
                    DVT = c.DVT,
                    HinhAnh = c.HinhAnh,
                    DonGia = (float)c.DonGia,
                    MaLoaiMonAn = c.MaLoaiMonAn,
                }).ToList();
            }
        }
        public List<DTO_MonAn> GetByLoaiMonAn(string maloai)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.MonAns
                    .Where(c => c.MaLoaiMonAn == maloai)
                    .Select(c => new DTO_MonAn
                    {
                        MaMonAn = c.MaMonAn,
                        TenMonAn = c.TenMonAn,
                        DVT = c.DVT,
                        HinhAnh = c.HinhAnh,
                        DonGia = (float)c.DonGia,
                        MaLoaiMonAn = c.MaLoaiMonAn,
                    }).ToList();
            }
        }

        public DTO_MonAn GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.MonAns.SingleOrDefault(c => c.MaMonAn == ma);
                if (item != null)
                {
                    return new DTO_MonAn
                    {
                        MaMonAn = item.MaMonAn,
                        TenMonAn = item.TenMonAn,
                        DVT = item.DVT,
                        HinhAnh = item.HinhAnh,
                        DonGia = (float)item.DonGia,
                        MaLoaiMonAn = item.MaLoaiMonAn,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_MonAn dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new MonAn
                {
                    MaMonAn = dto.MaMonAn,
                    TenMonAn = dto.TenMonAn,
                    DVT = dto.DVT,
                    HinhAnh = dto.HinhAnh,
                    DonGia = dto.DonGia,
                    MaLoaiMonAn = dto.MaLoaiMonAn,
                };

                context.MonAns.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_MonAn dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.MonAns.SingleOrDefault(c => c.MaMonAn == dto.MaMonAn);
                if (item != null)
                {
                    item.TenMonAn = dto.TenMonAn;
                    item.DVT = dto.DVT;
                    item.HinhAnh = dto.HinhAnh;
                    item.DonGia = dto.DonGia;
                    item.MaLoaiMonAn = dto.MaLoaiMonAn;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.MonAns.SingleOrDefault(c => c.MaMonAn == ma);
                if (item != null)
                {
                    context.MonAns.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
