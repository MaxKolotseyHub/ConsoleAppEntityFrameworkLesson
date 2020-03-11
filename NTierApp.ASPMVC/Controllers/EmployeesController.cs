using AutoMapper;
using NTierApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierApp.ASPMVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IMapper mapper;
        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            mapper = Automapper.GetMapper();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}