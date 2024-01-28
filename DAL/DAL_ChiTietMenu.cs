using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietMenu : DataProvider
    {
        public DAL_ChiTietMenu() { }

        public List<DTO_ChiTietMenu> GetAll(string matiec)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.ChiTietMenus
                    .Where(c => c.MaTiec == matiec)
                    .Select(c => new DTO_ChiTietMenu
                    {
                        MaTiec = c.MaTiec,
                        MaMenu = c.MaMenu,
                        SoLuongMenuCuaTiec = c.SoLuongMenuCuaTiec,
                        TongTien = (float)c.TongTien,
                        TrangThai = c.TrangThai,
                    }).ToList();
            }
        }

        public bool KiemTra(string matiec, string mamenu)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.ChiTietMenus.SingleOrDefault(c => c.MaTiec == matiec && c.MaMenu == mamenu);
                if (item != null)
                {
                    return true;
                }
                return false;
            }
        }


        public void Add(DTO_ChiTietMenu dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new ChiTietMenu
                {
                    MaTiec = dto.MaTiec,
                    MaMenu = dto.MaMenu,
                    SoLuongMenuCuaTiec = dto.SoLuongMenuCuaTiec,
                    TongTien = 0,
                    TrangThai = dto.TrangThai,
                };

                context.ChiTietMenus.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_ChiTietMenu dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                
                var item = context.ChiTietMenus.SingleOrDefault(c => c.MaTiec == dto.MaTiec && c.MaMenu == dto.MaMenu);
                if (item != null)
                {
                    item.SoLuongMenuCuaTiec += dto.SoLuongMenuCuaTiec;
                    var itemmenu = context.Menus.SingleOrDefault(c => c.MaMenu == dto.MaMenu);
                    item.TongTien = (float)((double)item.SoLuongMenuCuaTiec * itemmenu.DonGiaMenu);
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string matiec, string mamenu)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.ChiTietMenus.SingleOrDefault(c => c.MaTiec == matiec && c.MaMenu == mamenu);
                if (item != null)
                {
                    context.ChiTietMenus.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
