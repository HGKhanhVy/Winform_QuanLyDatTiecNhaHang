using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DichVu
    {
        DAL_DichVu dal;
        public BLL_DichVu()
        {
            dal = new DAL_DichVu();
        }

        public List<DTO_DichVu> GetAll()
        {
            return dal.GetAll();
        }
        public DTO_DichVu GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_DichVu dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_DichVu dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
