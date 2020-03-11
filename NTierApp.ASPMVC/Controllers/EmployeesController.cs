using AutoMapper;
using NTierApp.ASPMVC.Models;
using NTierApp.ASPMVC.Models.Employee;
using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Models;
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
            var employees = employeeService.GetEmployees();
            return View(mapper.Map<List<EmployeesViewModel>>(employees));
        }
        [HttpGet]
        public ActionResult Edit(long id)
        {
            var employee = employeeService.GetEmployee(id);
            if (employee != null)
                return View(mapper.Map<EditEmployeeViewModel>(employee));
            else return new HttpNotFoundResult();
        }
        [HttpPost]
        public ActionResult Edit(EditEmployeeViewModel employee)
        {
            employeeService.UpdateEmployee(mapper.Map<EmployeeBLL>(employee));
            return RedirectToAction("Index");
        }
        public ActionResult Delete(long id)
        {
            employeeService.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
        public ActionResult Details(long id)
        {
            var employee = employeeService.GetEmployee(id);
            if (employee != null)
                return View(mapper.Map<DetailsEmployeeViewModel>(employee));
            else return new HttpNotFoundResult();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel employee)
        {
            employeeService.AddEmployee(mapper.Map<EmployeeBLL>(employee));
            return RedirectToAction("Index");
        }
    }
}