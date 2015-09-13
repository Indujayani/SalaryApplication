using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DataConnect
    {
        public static SqlConnection NewCon;
        public static string Con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            NewCon = new SqlConnection(Con);
            return NewCon;
        }
    }
}
