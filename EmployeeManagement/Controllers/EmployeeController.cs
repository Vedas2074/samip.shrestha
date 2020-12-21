using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using EmployeeManagement.Models;
using EmployeeManagement.Data;

namespace EmployeeManagement.Controllers{
    public class EmployeeController: Controller{
        private readonly EMContext db;
        public EmployeeController(EMContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {   
            var employees = db.Employees.ToList();
            return View(employees);
        }
        public ActionResult Detail(int Id)
        {
            var employee = db.Employees.Find(Id);
            return View(employee);
        }
        [HttpGet]//default ma hunxa
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
         [HttpGet]//default ma hunxa
        public ActionResult Edit(int Id)
        {
            var employee = db.Employees.Find(Id);
            return View(employee);
        }

        [HttpPost]
         public IActionResult Edit(Employee employee)
        {
            db.Employees.Attach(employee);
           db.Employees.Update(employee);
           db.SaveChanges();
           return RedirectToAction("Index");
        }
         public ActionResult Delete(int Id)
        {
            var employee = db.Employees.Find(Id);
            return View(employee);
        }
        
        [HttpPost]
         public IActionResult Delete(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}