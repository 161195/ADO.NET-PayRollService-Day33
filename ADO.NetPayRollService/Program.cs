using System;

namespace ADO.NetPayRollService
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Uc-1
            Console.WriteLine("Hello And Welcome to Pay Roll Service!");
            //Uc-2
            EmployeeRepository payroll = new EmployeeRepository();
            payroll.GetAllEmployeeDetails();
            Console.ReadLine();
            //Uc-3
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.UpdateSalaryQuery();
            //uc-4
            EmployeeModel model = new EmployeeModel();
            model.EmployeeName = "Aniket";
            model.StartDate = DateTime.Now;
            model.gender = "M";
            //model.BasicPay = 91000.32;
            employeeRepository.AddEmployee(model);
            Console.ReadLine();
        }
    }
}
