using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NguoiDung : DataProvider
    {
        public DAL_NguoiDung() { }

        public DTO_NguoiDung GetByUserAndPass(string username,string password) 
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.NguoiDungs.SingleOrDefault(c => c.userName==username && c.password == password);
                if (item != null)
                {
                    return new DTO_NguoiDung
                    {
                        userName = item.userName,
                        hoTen = item.hoTen,
                    };
                }
                return null;
            }
        }   
    }
}
