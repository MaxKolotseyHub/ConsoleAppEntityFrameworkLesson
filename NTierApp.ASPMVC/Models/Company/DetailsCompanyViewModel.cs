using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models.Company
{
    public class DetailsCompanyViewModel
    {
        public long Id { get; set; }
        [Display(Name = "Название компании")]
        public string CompanyName { get; set; }
        [Display(Name = "Адрес")]
        public string CompanyAddress { get; set; }
        public List<EmployeeBLL> Employees{ get; set; }
    }
}