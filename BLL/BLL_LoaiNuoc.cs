using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_LoaiNuoc
    {
        DAL_LoaiNuoc dal;
        public BLL_LoaiNuoc()
        {
            dal = new DAL_LoaiNuoc();
        }

        public List<DTO_LoaiNuoc> GetAll()
        {
            return dal.GetAll();
        }

        public DTO_LoaiNuoc GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_LoaiNuoc dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_LoaiNuoc dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
