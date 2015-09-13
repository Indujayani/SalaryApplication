using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DataAccess
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
        }
        SqlConnection conn;

        public DataAccess()
        {
            conn = DataConnect.GetConnection();
        }

        public void Insert_Details(SqlCommand cmd)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Create_Employee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

        }


        public void Update_Details(SqlCommand cmd)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update_Employee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

        }

        public void Delete_Details(SqlCommand cmd)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Delete_Employee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

        }
        public DataSet Read_Details(SqlCommand cmd)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Read_Employee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }









    }
}
