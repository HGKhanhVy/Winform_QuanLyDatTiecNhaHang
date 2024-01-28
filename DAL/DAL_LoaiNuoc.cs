using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_LoaiNuoc : DataProvider
    {
        public DAL_LoaiNuoc() { }

        public List<DTO_LoaiNuoc> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.LoaiNuocs.Select(c => new DTO_LoaiNuoc
                {
                    MaLoaiNuoc = c.MaLoaiNuoc,
                    TenLoaiNuoc = c.TenLoaiNuoc
                }).ToList();
            }
        }

        public DTO_LoaiNuoc GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var loaidichvu = context.LoaiNuocs.SingleOrDefault(c => c.MaLoaiNuoc == ma);
                if (loaidichvu != null)
                {
                    return new DTO_LoaiNuoc
                    {
                        MaLoaiNuoc = loaidichvu.MaLoaiNuoc,
                        TenLoaiNuoc = loaidichvu.TenLoaiNuoc
                    };
                }
                return null;
            }
        }
        public void Add(DTO_LoaiNuoc dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new LoaiNuoc
                {
                    MaLoaiNuoc = dto.MaLoaiNuoc,
                    TenLoaiNuoc = dto.TenLoaiNuoc
                };

                context.LoaiNuocs.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_LoaiNuoc dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.LoaiNuocs.SingleOrDefault(c => c.MaLoaiNuoc == dto.MaLoaiNuoc);
                if (item != null)
                {
                    item.TenLoaiNuoc = dto.TenLoaiNuoc;

                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.LoaiNuocs.SingleOrDefault(c => c.MaLoaiNuoc == ma);
                if (item != null)
                {
                    context.LoaiNuocs.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
