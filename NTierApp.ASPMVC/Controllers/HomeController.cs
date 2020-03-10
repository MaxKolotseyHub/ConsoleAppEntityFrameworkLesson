using Autofac;
using AutoMapper;
using NTierApp.ASPMVC.Models;
using NTierApp.BLL;
using NTierApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace NTierApp.ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Mapper mapper;
        private readonly IContainer container;
        public HomeController()
        {
            container = AutofacConfig.ConfigureContainer("Default");
            mapper = Automapper.GetMapper();

        }
        public ActionResult Index()
        {

            var employeeService = container.Resolve(typeof(IEmployeeService)) as IEmployeeService;
            var companyService = container.Resolve(typeof(ICompanyService)) as ICompanyService;

            ViewBag.EmployeesCount = employeeService.GetEmployees().Count;
            ViewBag.CompaniesCount = companyService.GetCompanies().Count;

            return View();
        }

        public ActionResult Companies()
        {
            var companyService = container.Resolve(typeof(ICompanyService)) as ICompanyService;
            var companies = mapper.Map<List<CompaniesViewModel>>(companyService.GetCompanies());
            return View(companies);
        }
        public ActionResult Employees()
        {
            var employeeService = container.Resolve(typeof(IEmployeeService)) as IEmployeeService;
            var employees = mapper.Map<List<EmployeesViewModel>>(employeeService.GetEmployees());
            return View(employees);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}