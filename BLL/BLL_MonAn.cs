using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_MonAn
    {
        DAL_MonAn dal;
        public BLL_MonAn()
        {
            dal = new DAL_MonAn();
        }

        public List<DTO_MonAn> GetAll()
        {
            return dal.GetAll();
        }

        public List<DTO_MonAn> GetByLoaiMonAn(string maloai)
        {
            return dal.GetByLoaiMonAn(maloai);
        }

        public DTO_MonAn GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_MonAn dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_MonAn dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
