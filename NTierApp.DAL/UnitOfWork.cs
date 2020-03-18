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
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private EmployeeRepository employeeRepository;
        private CompanyRepository companyRepository;
        public UnitOfWork(string conntectionString)
        {
            db = new DatabaseContext(conntectionString);
        }
        public IEmployeeRepository<Employee> Employees
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

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
