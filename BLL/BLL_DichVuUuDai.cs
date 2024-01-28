using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DichVuUuDai
    {
        DAL_DichVuUuDai dal;
        public BLL_DichVuUuDai()
        {
            dal = new DAL_DichVuUuDai();
        }

        public List<DTO_DichVuUuDai> GetAll()
        {
            return dal.GetAll();
        }
        public DTO_DichVuUuDai GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_DichVuUuDai dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_DichVuUuDai dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}