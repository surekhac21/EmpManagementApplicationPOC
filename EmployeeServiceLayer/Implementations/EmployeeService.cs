using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeServiceLayer.Contracts;
using EmpMgmtData;
using EmpMgmtData.UnitOfWork;
using DomainModel;

namespace EmployeeServiceLayer.Implementations
{
    // <summary>
    /// Employee Service class will implement the definitions of Employee Interface abstract methods.
    /// </summary>
    /// <remarks>
    /// This class will connect with Employee Repository and reterive/update the data into Employee Data Entity.
    /// </remarks>
    public class EmployeeService : IEmployee
    {
        //Define the Interface for Unit of Work Interface.
        IUnitOfWork uow;

        /// <summary>
        /// Default Constructor with the IUnitofWork Parameter.
        /// Using the Unit of Work Interface and implementing dependency Injections by using the value in constructor.
        /// </summary>
        public EmployeeService(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        /// <summary>
        /// This method will connect the employee repository and reterive the employee details.
        /// </summary>
        /// <remarks>
        /// Reterive all the data without have any conditions.
        /// </remarks>
        public List<EmployeeModel> GetAllEmployees()
        {
            return uow.EmployeeRepository.GetAllIncluding().ToList();
        }
    }
}
