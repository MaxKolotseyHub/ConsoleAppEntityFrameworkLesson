using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly DatabaseContext db;

        public EmployeeRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Create(Employee item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
