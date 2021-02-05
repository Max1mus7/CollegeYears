using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using EmployeeCrud.Models;

namespace EmployeeCrud.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeData employeeDAL = new EmployeeData();
        public IActionResult Index()
        {
            //create a list from our class EmployeeInfo and create an object called empList
            List<EmployeeInfo> empList = new List<EmployeeInfo>();
            empList = employeeDAL.GetAllEmployees().ToList();
            return View(empList);
        }

        /// <summary>
        /// Controller if we are just calling this page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //The basic purpose of the ValidateAntiForgeryToken is to prevent
        //cross-site request forgery attacks.
        [ValidateAntiForgeryToken]
        //The [Bind] attribute is one way to protect against over-posting
        public IActionResult Create([Bind] EmployeeInfo objEmp)
        {
            //Make sure the data is valid(another form of validation)
            if (ModelState.IsValid)
            {
                employeeDAL.AddEmployee(objEmp);
                return RedirectToAction("Index");
            }
            return View(objEmp);
        }

        public IActionResult Create2([Bind] EmployeeInfo objEmp)
        {
            //Make sure the data is valid(another form of validation)
            if (ModelState.IsValid)
            {
                employeeDAL.AddEmployee(objEmp);
                return RedirectToAction("Index");
            }
            return View(objEmp);
        }

    }
}
