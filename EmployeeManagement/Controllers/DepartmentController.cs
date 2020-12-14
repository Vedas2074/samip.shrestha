using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Linq;


namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {   
           var departments = Department.GetDepartment();
            return View(departments); 
        }
          public ActionResult Detail(int Id)
        {
            var departments = Department.GetDepartment();
            var department=departments.FirstOrDefault(x=>x.Id==Id);
            return View(department);
        }
        [HttpGet]//default ma hunxa
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
         public string Create(Department department)
        {
            return "Record save";
        }
    }
}