using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DatTiec
    {
        DAL_DatTiec dal;
        public BLL_DatTiec()
        {
            dal = new DAL_DatTiec();
        }

        public List<DTO_DatTiec> GetAll()
        {
            return dal.GetAll();
        }
        public DTO_DatTiec GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public bool KiemTraID(string ma)
        {
            return dal.KiemTraID(ma);
        }

        public void Add(DTO_DatTiec dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_DatTiec dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}

