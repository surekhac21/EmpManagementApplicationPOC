using EmpMgmtData.Data;
using EmpMgmtData.RepoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace EmpMgmtData.Repository
{
    // <summary>
    /// EmployeeRepository class will inherit from EmployeeRepository Interface.
    /// </summary>
    /// <remarks>
    /// This class will return dbcontext to reterive/update the data.
    /// </remarks>
    public class EmployeeRepository : Repository<EmployeeModel>, IEmployeeRepository
    {
        //Employee repository class for data access.
        public EmployeeRepository(EmpDBEntities _context) : base(_context)
        {
        }

        //This Returns DBcontext to access data.
        public EmpDBEntities AppContext
        {
            get
            {
                return Context as EmpDBEntities;
            }
        }
    }
}
