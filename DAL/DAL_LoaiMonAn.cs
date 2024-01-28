using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiMonAn : DataProvider
    {
        public DAL_LoaiMonAn() { }

        public List<DTO_LoaiMonAn> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.LoaiMonAns.Select(c => new DTO_LoaiMonAn
                {
                    MaLoaiMonAn = c.MaLoaiMonAn,
                    TenLoaiMonAn = c.TenLoaiMon
                }).ToList();
            }
        }

        public DTO_LoaiMonAn GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var loaidichvu = context.LoaiMonAns.SingleOrDefault(c => c.MaLoaiMonAn == ma);
                if (loaidichvu != null)
                {
                    return new DTO_LoaiMonAn
                    {
                        MaLoaiMonAn = loaidichvu.MaLoaiMonAn,
                        TenLoaiMonAn = loaidichvu.TenLoaiMon
                    };
                }
                return null;
            }
        }
        public void Add(DTO_LoaiMonAn dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new LoaiMonAn
                {
                    MaLoaiMonAn = dto.MaLoaiMonAn,
                    TenLoaiMon = dto.TenLoaiMonAn
                };

                context.LoaiMonAns.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_LoaiMonAn dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.LoaiMonAns.SingleOrDefault(c => c.MaLoaiMonAn == dto.MaLoaiMonAn);
                if (item != null)
                {
                    item.TenLoaiMon = dto.TenLoaiMonAn;

                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.LoaiMonAns.SingleOrDefault(c => c.MaLoaiMonAn == ma);
                if (item != null)
                {
                    context.LoaiMonAns.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
