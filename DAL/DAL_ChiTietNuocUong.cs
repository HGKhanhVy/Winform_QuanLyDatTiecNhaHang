using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietNuocUong : DataProvider
    {
        public DAL_ChiTietNuocUong() { }

        public List<DTO_ChiTietNuocUong> GetAll(string matiec)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.ChiTietNuocUongs
                    .Where(c => c.MaTiec == matiec)
                    .Select(c => new DTO_ChiTietNuocUong
                    {
                        MaTiec = c.MaTiec,
                        MaNuoc = c.MaNuoc,
                        SoLuong = c.SoLuong,
                        TongTien = (float)c.TongTien,
                        TrangThai = c.TrangThai,
                    }).ToList();
            }
        }

        public bool KiemTra(string matiec,string manuoc)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.ChiTietNuocUongs.SingleOrDefault(c => c.MaTiec == matiec && c.MaNuoc == manuoc);
                if (item != null)
                {
                    return true;
                }
                return false;
            }
        }


        public void Add(DTO_ChiTietNuocUong dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var itemnuoc = context.Nuocs.SingleOrDefault(c => c.MaNuoc == dto.MaNuoc);
                dto.TongTien = (float)((double)dto.SoLuong * itemnuoc.DonGia);
                var item = new ChiTietNuocUong
                {
                    MaTiec = dto.MaTiec,
                    MaNuoc = dto.MaNuoc,
                    SoLuong = dto.SoLuong,
                    TongTien = dto.TongTien,
                    TrangThai = dto.TrangThai,
                };

                context.ChiTietNuocUongs.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_ChiTietNuocUong dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.ChiTietNuocUongs.SingleOrDefault(c => c.MaTiec == dto.MaTiec && c.MaNuoc == dto.MaNuoc);
                if (item != null)
                {
                    item.SoLuong += dto.SoLuong;
                    var itemnuoc = context.Nuocs.SingleOrDefault(c => c.MaNuoc == dto.MaNuoc);
                    item.TongTien = (double)item.SoLuong * itemnuoc.DonGia;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string matiec,string manuoc)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.ChiTietNuocUongs.SingleOrDefault(c => c.MaTiec == matiec && c.MaNuoc == manuoc);
                if (item != null)
                {
                    context.ChiTietNuocUongs.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
