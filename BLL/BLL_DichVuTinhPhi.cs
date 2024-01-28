using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DichVuTinhPhi
    {
        DAL_DichVuTinhPhi dal;
        public BLL_DichVuTinhPhi()
        {
            dal = new DAL_DichVuTinhPhi();
        }

        public List<DTO_DichVuTinhPhi> GetAll()
        {
            return dal.GetAll();
        }
        public DTO_DichVuTinhPhi GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_DichVuTinhPhi dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_DichVuTinhPhi dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
