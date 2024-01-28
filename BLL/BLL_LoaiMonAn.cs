using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_LoaiMonAn
    {
        DAL_LoaiMonAn dal;
        public BLL_LoaiMonAn()
        {
            dal = new DAL_LoaiMonAn();
        }

        public List<DTO_LoaiMonAn> GetAll()
        {
            return dal.GetAll();
        }

        public DTO_LoaiMonAn GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_LoaiMonAn dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_LoaiMonAn dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}