using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Repositories
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly DatabaseContext db;

        public CompanyRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Create(Company item)
        {
            db.Companies.Add(item);
        }

        public void Delete(int id)
        {
            var company = db.Companies.FirstOrDefault(c => c.Id == id);
            if (company != null)
                db.Companies.Remove(company);
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Company item)
        {
            throw new NotImplementedException();
        }
    }
}
