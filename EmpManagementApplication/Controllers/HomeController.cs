using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpManagementApplication.Controllers
{
    public class HomeController : Controller
    {
        //below code is written to handle crud operations for employee using entity framework,ado entity data model

        EmpDBEntities _context = new EmpDBEntities();
          
        /// <summary>
        /// To connect with service layer to get Data.
        /// </summary>
        /// <returns>Returns all the Employee List</returns>
        public ActionResult Index()
        {
            var listofData = _context.Employees.ToList();
            return View(listofData);
        }

        //This will add employees

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee model)
        {
            _context.Employees.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Data Insert Successfully";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Employee Model)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == Model.EmployeeId).FirstOrDefault();
            if (data != null)
            {
                data.EmployeeCity = Model.EmployeeCity;
                data.EmployeeName = Model.EmployeeName;
                data.EmployeeSalary = Model.EmployeeSalary;
                _context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        //This will show details of employee

        public ActionResult Detail(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }

        //To delete the employee
        public ActionResult Delete(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            _context.Employees.Remove(data);
            _context.SaveChanges();
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("index");
        }
        //below code has been written temporarily..needs to be updated.

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //below code has been written temporarily..needs to be updated.

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}