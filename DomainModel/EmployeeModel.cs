using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    /// <summary>
    /// The model that represents an Employee Data and bridge between Employee Pages and Data.
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// Gets and Sets the value of Employee Id Property.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets and Sets the value of EmployeeName Property.
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets and Sets the value of EmployeeSalary Property.
        /// </summary>
        public Nullable<decimal> EmployeeSalary { get; set; }

        /// <summary>
        /// Gets and Sets the value of EmployeeCity Property.
        /// </summary>
        public string EmployeeCity { get; set; }
    }
}
