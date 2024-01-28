using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using DTO;
using Castle.Core.Resource;

namespace DAL
{

    public class DAL_LoaiDichVu : DataProvider
    {
        public DAL_LoaiDichVu()
        {
        }

        public List<DTO_LoaiDichVu> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.LoaiDichVus.Select(c => new DTO_LoaiDichVu
                {
                    MaLoaiDichVu = c.MaLoaiDichVu,
                    TenLoaiDichVu = c.TenLoaiDichVu
                }).ToList();
            }
        }

        public DTO_LoaiDichVu GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var loaidichvu = context.LoaiDichVus.SingleOrDefault(c => c.MaLoaiDichVu == ma);
                if (loaidichvu != null)
                {
                    return new DTO_LoaiDichVu
                    {
                        MaLoaiDichVu = loaidichvu.MaLoaiDichVu,
                        TenLoaiDichVu = loaidichvu.TenLoaiDichVu
                    };
                }
                return null;
            }
        }
        public void Add(DTO_LoaiDichVu dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new LoaiDichVu
                {
                    MaLoaiDichVu = dto.MaLoaiDichVu,
                    TenLoaiDichVu = dto.TenLoaiDichVu
                };

                context.LoaiDichVus.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_LoaiDichVu dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.LoaiDichVus.SingleOrDefault(c => c.MaLoaiDichVu == dto.MaLoaiDichVu);
                if (item != null)
                {
                    item.TenLoaiDichVu = dto.TenLoaiDichVu;

                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.LoaiDichVus.SingleOrDefault(c => c.MaLoaiDichVu == ma);
                if (item != null)
                {
                    context.LoaiDichVus.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
