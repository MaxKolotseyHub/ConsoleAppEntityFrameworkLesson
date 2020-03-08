using NTierApp.DAL.Entities;
using NTierApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL
{
    class ContextInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var company1 = new Entities.Company() { Address = "Belarus, Minsk, str. Krasnaya 7", Name = "Alfa-Bank"}; 
            var company2 = new Entities.Company() { Address = "Belarus, Minsk, str. Coolman 21", Name = "ITransition"};

            context.Companies.Add(company1);
            context.Companies.Add(company2);

            var employee1 = new Employee() { FirstName = "Max", LastName = "Yestolok", Age = 21 };
            var employee2 = new Employee() { FirstName = "Alex", LastName = "Stateham", Age = 41 };

            employee1.Companies.Add(company1);
            employee1.Companies.Add(company2);
            employee2.Companies.Add(company2);

            context.Employees.Add(employee1);
            context.Employees.Add(employee2);

            context.SaveChanges();
        }
    }
}
