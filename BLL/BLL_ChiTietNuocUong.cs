using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ChiTietNuocUong
    {
        DAL_ChiTietNuocUong dal;
        public BLL_ChiTietNuocUong()
        {
            dal = new DAL_ChiTietNuocUong();
        }

        public List<DTO_ChiTietNuocUong> GetAll(string matiec)
        {
            return dal.GetAll(matiec);
        }

        public bool KiemTra(string matiec, string manuoc)
        {
            return dal.KiemTra(matiec, manuoc);
        }

        public void Add(DTO_ChiTietNuocUong dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_ChiTietNuocUong dto)
        {
            dal.Update(dto);
        }

        public void Delete(string matiec,string manuoc)
        {
            dal.Delete(matiec,manuoc);
        }
    }
}
