using System;

namespace ADO.NetPayRollService
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello And Welcome to Pay Roll Service!");
            EmployeeRepository payroll = new EmployeeRepository();
            payroll.GetAllEmployeeDetails();
            Console.ReadLine();
        }
    }
}
