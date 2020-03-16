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
        void AddCompany(long companyId, long employeeId);
        void DeleteCompany(long companyId, long employeeId);
        void Save();
        ICollection<EmployeeBLL> GetEmployees();
        EmployeeBLL GetEmployee(long id);
        void DeleteEmployee(long id);
    }
}
