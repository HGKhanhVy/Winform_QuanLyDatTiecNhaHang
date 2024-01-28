using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NguoiDung
    {
        DAL_NguoiDung dal;

        public BLL_NguoiDung()
        {
            dal = new DAL_NguoiDung();
        }
        public DTO_NguoiDung GetByUserAndPass(string username, string password)
        {
            return dal.GetByUserAndPass(username, password);
        }
    }
}
