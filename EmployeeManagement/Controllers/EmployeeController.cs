using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers{
    public class EmployeeController: Controller{
        public IActionResult Index()
        {   
            var employees = Employee.GetEmployee();
            return View(employees);
        }
        public ActionResult Detail(int Id)
        {
            var employees = Employee.GetEmployee();
            var employee=employees.FirstOrDefault(x=>x.Id==Id);
            return View(employee);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}