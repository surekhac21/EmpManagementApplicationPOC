using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using EmpMgmtData.RepoInterface;

namespace EmpMgmtData.UnitOfWork
{

    /// <summary>
    /// Class <c>Unit of Work</c> This Class will derive the abstractions for the Employee Repository
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// This interface will replicate the employee Repository and inject in the constructor
        /// </summary>
        IEmployeeRepository EmployeeRepository { get; set; }
        /// <summary>
        /// Abstractions for the save and commit operations
        /// </summary>
        /// <remarks>
        /// Implement this interface to complete the save and commit operations.
        /// </remarks>
        int Complete();
    }
}
