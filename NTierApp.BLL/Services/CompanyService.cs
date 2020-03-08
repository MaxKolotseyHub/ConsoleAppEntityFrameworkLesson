using AutoMapper;
using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Models;
using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly Mapper mapper;

        public CompanyService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            mapper = Automapper.GetMapper();
        }

        public void AddCompany(CompanyBLL company)
        {
            var companyDAL = mapper.Map<CompanyBLL, Company>(company);
            unitOfWork.Companies.Create(companyDAL);
            unitOfWork.Save();
        }

        public void DeleteCompany(long id)
        {
            unitOfWork.Companies.Delete(id);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }

        public ICollection<CompanyBLL> GetCompanies()
        {
            return mapper.Map<List<CompanyBLL>>(unitOfWork.Companies.GetAll());
        }

        public CompanyBLL GetCompany(long id)
        {
            var comp = unitOfWork.Companies.Get(id);
            if (comp != null)
                return mapper.Map<CompanyBLL>(comp);
            else return null;
        }
    }
}
