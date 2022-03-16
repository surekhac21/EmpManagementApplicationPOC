using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmpManagementApplication.Controllers
{
    /// <summary>
    /// Class <c>Employee Controller</c> This Controller will handle the request for Employee Details
    /// </summary>
    public class EmployeeController : Controller
    {
        //Internal object created for the APIHelpers class
        EmployeeAPIHelper employeeAPIHelper = new EmployeeAPIHelper();

        /// <summary>
        /// This method will call the default index page
        /// </summary>
        /// <remarks>
        /// Reterive the Index View
        /// </remarks>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This method will fetch the employee data and bind the data to the view.
        /// </summary>
        /// <returns>Returns all the Employee View List</returns>
        [HttpGet]
        //Placeholder for  the authorize attribute, implementations is done.
        [Authorize]
        public async Task<IActionResult> EmployeeListView()
        {
            var employees = await employeeAPIHelper.GetAllEmployees();
            return View(employees.ToList());
        }
    }
}