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
            //var company = new CompanyBLL();
            //Console.WriteLine("Введите название комании");
            //company.CompanyName = Console.ReadLine();

            //Console.WriteLine("Введите адрес комании");
            //company.CompanyAddress = Console.ReadLine();

            // AutofacConfig.ConfigureContainer("Default");
            //var companyService = container.Resolve(typeof(ICompanyService)) as ICompanyService;
            //var employeeSrvice = container.Resolve(typeof(IEmployeeService)) as IEmployeeService;
            ////service.AddCompany(company);
            //var companies = companyService.GetCompanies();
            //var employees = employeeSrvice.GetEmployees();
        }

    }
}
