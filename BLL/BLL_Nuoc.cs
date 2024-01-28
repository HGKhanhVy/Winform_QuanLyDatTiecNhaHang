using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Nuoc
    {
        DAL_Nuoc dal;
        public BLL_Nuoc()
        {
            dal = new DAL_Nuoc();
        }

        public List<DTO_Nuoc> GetAll()
        {
            return dal.GetAll();
        }
        public List<DTO_Nuoc> GetAll(string maloainuoc)
        {
            return dal.GetAll(maloainuoc);
        }
        public DTO_Nuoc GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_Nuoc dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_Nuoc dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
