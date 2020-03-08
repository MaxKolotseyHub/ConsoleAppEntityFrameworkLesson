﻿using NTierApp.DAL.Entities;
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
            return db.Companies.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Company> GetAll()
        {
            return db.Companies.ToList();
        }

        public void Update(Company item)
        {
            var company = db.Companies.FirstOrDefault(c => c.Id == item.Id);
            if (company != null)
                company = item;
        }
    }
}
