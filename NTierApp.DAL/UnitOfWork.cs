using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using NTierApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL
{
    class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private EmployeeRepository employeeRepository;
        private CompanyRepository companyRepository;
        public UnitOfWork(string connectionString)
        {
            db = new DatabaseContext(connectionString);
        }
        public IRepository<Employee> Employees
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(db);
                return employeeRepository;
            }
        }

        public IRepository<Company> Companies
        {
            get
            {
                if (companyRepository == null)
                    companyRepository = new CompanyRepository(db);
                return companyRepository;
            }
        }

        public void Dispose()
        {

        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
