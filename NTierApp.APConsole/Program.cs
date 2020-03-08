using Autofac;
using NTierApp.BLL;
using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Models;
using NTierApp.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.APConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new CompanyBLL();
            Console.WriteLine("Введите название комании");
            company.CompanyName = Console.ReadLine();

            Console.WriteLine("Введите адрес комании");
            company.CompanyAddress = Console.ReadLine();

            var container = AutofacConfig.ConfigureContainer();
            var service = container.Resolve(typeof(ICompanyService)) as ICompanyService;
            service.AddCompany(company);
            var companies = service.GetCompanies();
            
        }

    }
}
