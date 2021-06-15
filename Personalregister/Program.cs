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
            int chck = 1;
            EmpRegister.RegisterEmployee(GetEmpName(), GetEmpSalary());
            
          
           while (chck == 1)
            {
                Console.WriteLine("If You Want To Add Another Employee press 1:");
                chck = int.Parse(Console.ReadLine());
                if (chck ==1)
                EmpRegister.RegisterEmployee(GetEmpName(), GetEmpSalary());
                else
                    chck = 0;
            }
        }
        static string GetEmpName() 
        {
            Console.WriteLine("Enter Name of Employee :");
            string EmployeeName = Console.ReadLine();
            return EmployeeName;
        }
        static float GetEmpSalary()
        {
            Console.WriteLine("Enter Salary of Employee :");
            float EmployeeSalary = 0;
            float.TryParse(Console.ReadLine(), out EmployeeSalary);
            return EmployeeSalary;
        }
    }
}
