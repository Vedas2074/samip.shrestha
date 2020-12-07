using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers{
    public class EmployeeController: Controller{
        public IActionResult Index()
        {   
            Employee employee1 = new Employee()
            {
                Id =1,
                FirstName = "Rem",
                LastName ="Hari", 
                Address = "Ktm",
                Age = 23,
                Salary = 1247

            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Samip",
                LastName ="Stha", 
                Address ="Bkt",
                Age = 32,
                Salary = 123

            };
            List<Employee> employees =new List<Employee>(){employee1,employee2};
            return View(employees);
        }
    }
}