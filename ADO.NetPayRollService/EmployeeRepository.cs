using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NetPayRollService
{
    public class EmployeeRepository
    {
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=EmployeePayroll;";
        //creating object of sqlconnection class and creating connection with database
        SqlConnection sqlconnection = new SqlConnection(connectionString);

    }
}
