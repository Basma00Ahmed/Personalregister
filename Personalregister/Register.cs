using System;
using System.Collections.Generic;
using System.Text;

namespace Personalregister
{
    public class Register
    { 
        List<EmployeeInfo> employees = new List<EmployeeInfo>();


        public List<EmployeeInfo> RegisterEmployee(string EmpName, float EmpSalary)
        {
            EmployeeInfo Employee = new EmployeeInfo();
            Employee.EmployeeName = EmpName;
            Employee.EmployeeSalary = EmpSalary;


            employees.Add(Employee);
            Console.WriteLine("Numbers of Employees :  " + employees.Count);
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.EmployeeName + "  ||  " + emp.EmployeeSalary.ToString());
            }
            Console.WriteLine("---------------------------------------------");
       

            return employees;

        }
    }
}
