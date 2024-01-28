using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Nuoc : DataProvider
    {
        public DAL_Nuoc() { }

        public List<DTO_Nuoc> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.Nuocs.Select(c => new DTO_Nuoc
                {
                    MaNuoc = c.MaNuoc,
                    TenNuoc = c.TenNuoc,
                    DVT = c.DVT,
                    HinhAnh = c.HinhAnh,
                    DonGia = (float)c.DonGia,
                    MaLoaiNuoc=c.MaLoaiNuoc,
                }).ToList();
            }
        }

        public List<DTO_Nuoc> GetAll(string maloainuoc)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.Nuocs
                    .Where(c => c.MaLoaiNuoc == maloainuoc)
                    .Select(c => new DTO_Nuoc
                    {
                        MaNuoc = c.MaNuoc,
                        TenNuoc = c.TenNuoc,
                        DVT = c.DVT,
                        HinhAnh = c.HinhAnh,
                        DonGia = (float)c.DonGia,
                        MaLoaiNuoc = c.MaLoaiNuoc,
                    }).ToList();
            }
        }

        public DTO_Nuoc GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.Nuocs.SingleOrDefault(c => c.MaNuoc == ma);
                if (item != null)
                {
                    return new DTO_Nuoc
                    {
                        MaNuoc = item.MaNuoc,
                        TenNuoc = item.TenNuoc,
                        DVT = item.DVT,
                        HinhAnh = item.HinhAnh,
                        DonGia = (float)item.DonGia,
                        MaLoaiNuoc = item.MaLoaiNuoc,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_Nuoc dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new Nuoc
                {
                    MaNuoc = dto.MaNuoc,
                    TenNuoc = dto.TenNuoc,
                    DVT = dto.DVT,
                    HinhAnh = dto.HinhAnh,
                    DonGia = dto.DonGia,
                    MaLoaiNuoc = dto.MaLoaiNuoc,
                };

                context.Nuocs.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_Nuoc dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.Nuocs.SingleOrDefault(c => c.MaNuoc == dto.MaNuoc);
                if (item != null)
                {
                    item.TenNuoc = dto.TenNuoc;
                    item.DVT = dto.DVT;
                    item.HinhAnh = dto.HinhAnh;
                    item.DonGia = dto.DonGia;
                    item.MaLoaiNuoc = dto.MaLoaiNuoc;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.Nuocs.SingleOrDefault(c => c.MaNuoc == ma);
                if (item != null)
                {
                    context.Nuocs.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
