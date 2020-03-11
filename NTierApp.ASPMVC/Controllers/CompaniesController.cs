using AutoMapper;
using NTierApp.ASPMVC.Models;
using NTierApp.ASPMVC.Models.Company;
using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierApp.ASPMVC.Controllers
{
    public class CompaniesController : Controller
    {
        // GET: Companies
        private readonly ICompanyService companyService;
        private readonly IMapper mapper;
        public CompaniesController(ICompanyService companyService)
        {
            this.companyService = companyService;
            mapper = Automapper.GetMapper();
        }

        public ActionResult Index()
        {
            var companies = mapper.Map<List<CompaniesViewModel>>(companyService.GetCompanies());
            return View(companies);
        }
        [HttpGet]
        public ActionResult Edit(long id)
        {
            var company = companyService.GetCompany(id);
            if (company != null)
                return View(mapper.Map<EditCompanyViewModel>(company));
            else
                return new HttpNotFoundResult();
        }
        [HttpPost]
        public ActionResult Edit(EditCompanyViewModel edited)
        {
            companyService.Update(mapper.Map<CompanyBLL>(edited));
            return RedirectToAction("Index");
        }
        public ActionResult Details(long id)
        {
            var company = companyService.GetCompany(id);
            if (company != null)
                return View(mapper.Map<DetailsCompanyViewModel>(company));
            else return new HttpNotFoundResult();
        }
        public ActionResult Delete(long id)
        {
            companyService.DeleteCompany(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CreateCompanyViewModel model)
        {
            companyService.AddCompany(mapper.Map<CompanyBLL>(model));
            return RedirectToAction("Index");
        }
    }
}