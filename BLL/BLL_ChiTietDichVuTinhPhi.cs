using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ChiTietDichVuTinhPhi
    {
        DAL_ChiTietDichVuTinhPhi dal;
        public BLL_ChiTietDichVuTinhPhi()
        {
            dal = new DAL_ChiTietDichVuTinhPhi();
        }

        public List<DTO_ChiTietDichVuTinhPhi> GetAll(string matiec)
        {
            return dal.GetAll(matiec);
        }

        public void Add(DTO_ChiTietDichVuTinhPhi dto)
        {
            dal.Add(dto);
        }

        public bool KiemTra(string matiec, string madichvutinhphi)
        {
            return dal.KiemTra(matiec, madichvutinhphi);
        }

        public void Delete(string matiec, string madichvutinhphi)
        {
            dal.Delete(matiec, madichvutinhphi);
        }
    }
}
