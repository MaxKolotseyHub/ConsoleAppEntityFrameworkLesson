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
using NTierApp.BLL.Models;

namespace NTierApp.ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IEmployeeService employeeService;
        private readonly ICompanyService companyService;
        public HomeController(IEmployeeService employeeService, ICompanyService companyService)
        {
            this.employeeService = employeeService;
            this.companyService = companyService;
            mapper = Automapper.GetMapper();
        }
        public ActionResult Index()
        {
            ViewBag.EmployeesCount = employeeService.GetEmployees().Count;
            ViewBag.CompaniesCount = companyService.GetCompanies().Count;

            return View();
        }

        public ActionResult Companies()
        {
            var companies = mapper.Map<List<CompaniesViewModel>>(companyService.GetCompanies());
            return View(companies);
        }
        public ActionResult Employees()
        {
            var employees = mapper.Map<List<EmployeesViewModel>>(employeeService.GetEmployees());
            return View(employees);
        }
        [HttpGet]
        public ActionResult EditEmployee(long id)
        {
            var employee = employeeService.GetEmployee(id);
            return View(mapper.Map<EditEmployeeViewModel>(employee));
        }
        [HttpPost]
        public ActionResult EditEmployee(EditEmployeeViewModel editEmployee)
        {
            employeeService.UpdateEmployee(mapper.Map<EmployeeBLL>(editEmployee));
            return RedirectToAction("Employees");
        }
        public ActionResult DetailsEmployee(long id)
        {
            var employee = employeeService.GetEmployee(id);
            return View(mapper.Map<DetailsEmployeeViewModel>(employee));
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