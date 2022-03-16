using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace EmpMgmtData.RepoInterface
{
    /// <summary>
    /// This interface for working with EmployeeRepository
    public interface IEmployeeRepository : IRepository<EmployeeModel>
    {

    }
}
