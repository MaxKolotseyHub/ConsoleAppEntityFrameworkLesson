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
            db.Employees.Add(item);
        }

        public void Delete(long id)
        {
            var employee = db.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
                db.Employees.Remove(employee);
        }

        public Employee Get(long id)
        {
            return db.Employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public void Update(Employee item)
        {
            var employee = db.Employees.FirstOrDefault(e => e.Id == item.Id);
            if (employee != null)
            {
                db.Employees.Attach(employee);
                employee.Age = item.Age;
                employee.FirstName = item.FirstName;
                employee.LastName = item.LastName;
            }
        }
    }
}
