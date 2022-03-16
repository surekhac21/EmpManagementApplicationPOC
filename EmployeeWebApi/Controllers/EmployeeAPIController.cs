// Using the reference of Service Layer Contracts and Domain Model to Handle the EmployeeAPI Module.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DomainModel;
using EmployeeServiceLayer.Contracts;

//Common Namespace for the API Controllers
namespace EmployeeWebApi.Controllers
{
    /// <summary>
    /// Class <c>EmployeeAPI Controller</c> This Controller will handle the request for Employee Details
    /// </summary>
    public class EmployeeAPIController : ApiController
    {
        // Interface for Employee Service
        IEmployee employeeService;

        /// <summary>
        /// Default Constructor with the IEmployee Interface Parameter
        /// </summary>
        public EmployeeAPIController(IEmployee _employeeService)
        {
            employeeService = _employeeService;
        }

        /// <summary>
        /// To connect with service layer to get Data.
        /// </summary>
        /// <returns>Returns all the Employee List</returns>
        [HttpGet]
        public List<EmployeeModel> GetAll()
        {
            var employeeList = employeeService.GetAllEmployees().ToList();
            return employeeList;
        }

        // Remaining implementation of Employee class.

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}