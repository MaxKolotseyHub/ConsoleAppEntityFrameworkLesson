using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Interfaces
{
    public interface IEmployeeRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Create(T item);
        void Update(T item);
        void Delete(long id);
        void AddCompany(long employeeId, long companyId);
        void DeleteCompany(long employeeId, long companyId);
    }
}
