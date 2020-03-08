using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Interfaces
{
    public interface ICompanyService:IDisposable
    {
        void AddCompany(CompanyBLL company);
        ICollection<CompanyBLL> GetCompanies();
        CompanyBLL GetCompany(long id);
        void DeleteCompany(CompanyBLL company);

    }
}
