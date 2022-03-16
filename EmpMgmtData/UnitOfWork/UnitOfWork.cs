using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpMgmtData.RepoInterface;
using EmpMgmtData.Repository;
using EmpMgmtData.Data;

namespace EmpMgmtData.UnitOfWork
{
    // <summary>
    /// Unit of Service class will implement the definitions of IUnitofWork Interface abstract methods.
    /// </summary>
    /// <remarks>
    /// This class will inject the IUnitofwork interface and connect the  Repository.
    /// </remarks>
    /// ///<inheritdoc cref="IUnitofWork"/>
    public class UnitOfWork : IUnitOfWork
    {
        private EmpDBEntities _context;

        /// <summary>
        /// Constructor for the Unit of work service to inject the db context from entity data model
        /// </summary>
        public UnitOfWork(EmpDBEntities context)
        {
            _context = context;
            EmployeeRepository = new EmployeeRepository(context);
        }

        ///// <summary>
        /// Interface for EmployeeRepository
        /// </summary>
        public IEmployeeRepository EmployeeRepository { get; set; }

        /// <summary>
        /// Method for the save and commit operations
        /// </summary>
        /// <remarks>
        /// This will do the save operations
        /// </remarks>
        public int Complete()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Finalize and dispose method for object
        /// </summary>
        /// <remarks>
        /// Dispose the dbcontext object
        /// </remarks>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
