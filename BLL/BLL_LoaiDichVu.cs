using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_LoaiDichVu
    {
        DAL_LoaiDichVu dal;
        public BLL_LoaiDichVu() 
        {
            dal = new DAL_LoaiDichVu();
        }

        public List<DTO_LoaiDichVu> GetAll()
        {
            return dal.GetAll();
        }

        public DTO_LoaiDichVu GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_LoaiDichVu dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_LoaiDichVu dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
