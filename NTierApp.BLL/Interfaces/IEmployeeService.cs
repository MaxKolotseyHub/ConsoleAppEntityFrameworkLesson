using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Interfaces
{
    public interface IEmployeeService:IDisposable
    {
        void AddEmployee(EmployeeBLL employee);
        void UpdateEmployee(EmployeeBLL employee);
        ICollection<EmployeeBLL> GetEmployees();
        EmployeeBLL GetEmployee(long id);
        void DeleteEmployee(long id);
    }
}
