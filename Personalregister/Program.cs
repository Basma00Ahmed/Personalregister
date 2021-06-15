using System;
using System.Collections.Generic;
namespace Personalregister
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Employees registration----------------------");
            Register EmpRegister = new Register();

            Console.WriteLine("Enter Name of Employee :");
            string EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter Salary of Employee :");
            float EmployeeSalary = 0;
            float.TryParse(Console.ReadLine(), out EmployeeSalary);
   
            EmpRegister.RegisterEmployee(EmployeeName,EmployeeSalary);


        }
    }
}
