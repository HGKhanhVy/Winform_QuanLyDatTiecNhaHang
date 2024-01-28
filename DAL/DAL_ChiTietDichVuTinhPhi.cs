using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietDichVuTinhPhi : DataProvider
    {
        public DAL_ChiTietDichVuTinhPhi() { }
         
        public List<DTO_ChiTietDichVuTinhPhi> GetAll(string matiec)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.ChiTietDichVuTinhPhis
                    .Where(c => c.MaTiec ==  matiec)
                    .Select(c => new DTO_ChiTietDichVuTinhPhi
                    {
                        MaTiec = c.MaTiec,
                        MaDichVuTinhPhi = c.MaDichVuTinhPhi,
                        TrangThai = c.TrangThai,
                    }).ToList();
            }
        }
        public bool KiemTra(string matiec, string madichvutinhphi)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.ChiTietDichVuTinhPhis.SingleOrDefault(c => c.MaTiec == matiec && c.MaDichVuTinhPhi == madichvutinhphi);
                if (item != null)
                {
                    return true;
                }
                return false;
            }
        }

        public void Add(DTO_ChiTietDichVuTinhPhi dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new ChiTietDichVuTinhPhi
                {
                    MaTiec = dto.MaTiec,
                    MaDichVuTinhPhi = dto.MaDichVuTinhPhi,
                    TrangThai = dto.TrangThai,
                };

                context.ChiTietDichVuTinhPhis.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Delete(string matiec,string madichvutinhphi)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.ChiTietDichVuTinhPhis.SingleOrDefault(c => c.MaTiec == matiec && c.MaDichVuTinhPhi == madichvutinhphi);
                if (item != null)
                {
                    context.ChiTietDichVuTinhPhis.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}

