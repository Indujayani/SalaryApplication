using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;
using Property;
namespace BussinessLayer
{
   public class Bussiness
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

        }
       DataAccess da = new DataAccess();
        SqlCommand cmd=new SqlCommand();


        public void insert_details(Employee emp)
        {
           
            cmd.Parameters.AddWithValue("@Id ", emp.employeeId);
            cmd.Parameters.AddWithValue("@Name ",emp.employeeName);
            cmd.Parameters.AddWithValue("@Address ",emp.employeeAddress);
            cmd.Parameters.AddWithValue("@Age ",emp.employeeAge);
            cmd.Parameters.AddWithValue("@ContactNo ",emp.employeeContactNumber);
            cmd.Parameters.AddWithValue("@NoOfHours ",emp.employeeNoOfHours);
            cmd.Parameters.AddWithValue("@HourlyRate ", 56);
            cmd.Parameters.AddWithValue("@Type ", emp.employeeType);
            cmd.Parameters.AddWithValue("@OTHourlyRate ", 23);
            cmd.Parameters.AddWithValue("@BasicSal ", 45);
            da.Insert_Details(cmd);
        
        }

        public void update_details(Employee emp)
        {
            cmd.Parameters.AddWithValue("@Id ", emp.employeeId);
            cmd.Parameters.AddWithValue("@Name ", emp.employeeName);
            cmd.Parameters.AddWithValue("@Address ", emp.employeeAddress);
            cmd.Parameters.AddWithValue("@Age ", emp.employeeAge);
            cmd.Parameters.AddWithValue("@ContactNo ", emp.employeeContactNumber);
            cmd.Parameters.AddWithValue("@NoOfHours ", emp.employeeNoOfHours);
            cmd.Parameters.AddWithValue("@HourlyRate ", 56);
            cmd.Parameters.AddWithValue("@Type ", emp.employeeType);
            cmd.Parameters.AddWithValue("@OTHourlyRate ", 23);
            cmd.Parameters.AddWithValue("@BasicSal ", 45);
            da.Update_Details(cmd);
        }

        public void delete_details(int id)
        {
            cmd.Parameters.AddWithValue("@Id", id);
            da.Delete_Details(cmd);
        }
        public DataSet read_details(int id)
        {
            cmd.Parameters.AddWithValue("@Id ", id);
            return da.Read_Details(cmd);
        
        }

    }
    
}
