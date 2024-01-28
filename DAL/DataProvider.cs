using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        //public string connectionString = "Data Source=LAPTOP-POTNR7PE;Initial Catalog=DB_WeddingRestaurant;Integrated Security=True";
        public string connectionString = "Server=(local);Database=DB_WeddingRestaurant;User Id=sa;Password=123;TrustServerCertificate=true;";

        public DataProvider()
        {

        }
    }
}
