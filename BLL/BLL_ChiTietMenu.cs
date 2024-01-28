using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ChiTietMenu
    {
        DAL_ChiTietMenu dal;
        public BLL_ChiTietMenu()
        {
            dal = new DAL_ChiTietMenu();
        }

        public List<DTO_ChiTietMenu> GetAll(string matiec)
        {
            return dal.GetAll(matiec);
        }

        public bool KiemTra(string matiec, string mamenu)
        {
            return dal.KiemTra(matiec, mamenu);
        }

        public void Add(DTO_ChiTietMenu dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_ChiTietMenu dto)
        {
            dal.Update(dto);
        }

        public void Delete(string matiec, string mamenu)
        {
            dal.Delete(matiec, mamenu);
        }
    }
}
