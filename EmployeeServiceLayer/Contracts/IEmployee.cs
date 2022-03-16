using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace EmployeeServiceLayer.Contracts
{
    /// <summary>
    /// This interface would describe all the methods in IEmployee
    /// its contract.
    /// </summary>
    /// <remarks>
    /// Each method or property
    /// in this IEmployee interface would contain docs that you want
    /// to duplicate in each implementing class. 
    /// </remarks>
    public interface IEmployee
    {
        /// <summary>
        /// This method will reterive all the employee List interface.
        /// </summary>
        /// <remarks>
        /// Implement this interface to reterive all the employees.
        /// </remarks>
        List<EmployeeModel> GetAllEmployees();
    }
}
