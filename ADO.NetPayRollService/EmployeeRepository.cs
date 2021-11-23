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
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Payroll_Services_Database;";
        //creating object of sqlconnection class and creating connection with database
        SqlConnection sqlconnection = new SqlConnection(connectionString);
       
        public void GetAllEmployeeDetails()
        {
            try
            {
                EmployeeModel model = new EmployeeModel();        
                string query = @"select * from employee_payroll;";         //query for fetching the data from database                
                SqlCommand command = new SqlCommand(query, sqlconnection); //command object to execute query on given database
                sqlconnection.Open();                
                SqlDataReader reader = command.ExecuteReader();            //returning as rows
                
                if (reader.HasRows)                              //condition to check rows present or not in selected database
                {
                    //if rows are present then read the rows 
                    while (reader.Read())
                    {
                        model.EmployeeId = Convert.ToInt32(reader["Id"] == DBNull.Value ? default : reader["Id"]);
                        model.EmployeeName = Convert.ToString(reader["Name"] == DBNull.Value ? default : reader["Name"]);
                        model.salary = Convert.ToDouble(reader["Salary"] == DBNull.Value ? default : reader["Salary"]);
                        model.StartDate = (DateTime)(reader["StartDate"] == DBNull.Value ? default : reader["StartDate"]);
                        model.gender = Convert.ToString(reader["Gender"] == DBNull.Value ? default : reader["Gender"]);
                        model.phoneNumber = Convert.ToInt32(reader["Phone"] == DBNull.Value ? default : reader["Phone"]);
                        model.Address = Convert.ToString(reader["Address"] == DBNull.Value ? default : reader["Address"]);
                        //model.department = Convert.ToString(reader["Department"] == DBNull.Value ? default : reader["Department"]);
                        model.TaxablePay = Convert.ToDouble(reader["Taxable_Pay"] == DBNull.Value ? default : reader["Taxable_Pay"]);
                        model.IncomeTax = Convert.ToDouble(reader["Income_Tax"] == DBNull.Value ? default : reader["Income_Tax"]);
                        model.NetPay = Convert.ToDouble(reader["Net_Pay"] == DBNull.Value ? default : reader["Net_Pay"]);

                        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", model.EmployeeId, model.EmployeeName, model.salary, model.StartDate, model.gender, model.phoneNumber, model.Address, model.TaxablePay, model.IncomeTax,model.NetPay);
                        Console.WriteLine("\n");
                    }
                }
                else
                {
                    Console.WriteLine("No Data Found");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
        }
    }
}
