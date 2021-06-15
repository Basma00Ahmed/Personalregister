using Microsoft.VisualStudio.TestTools.UnitTesting;
using Personalregister;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personalregister.Tests
{
    [TestClass()]
    public class RegisterTests
    {
        [TestMethod()]
        public void RegisterEmployeeTest()
        {
            Register EmpRegister = new Register();

          
            string EmployeeName = "TestName";
            float EmployeeSalary = 100;

            var list =EmpRegister.RegisterEmployee(EmployeeName, EmployeeSalary);
            Assert.AreEqual(1, list.Count);
        }
    }
}