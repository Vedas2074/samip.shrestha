using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
using System.Collections.Generic;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {   
            Department department1 = new Department()
            {
                Id =1,
                Name = "Abc",
                Code =5464, 
                Branch = "Ktm",

            };
            Department department2 = new Department()
            {
                Id = 2,
                Name = "Eda",
                Code =5464, 
                Branch = "Ktm",


            };
            List<Department> departments =new List<Department>(){department1,department2};
            return View(departments);
        }
    }
}