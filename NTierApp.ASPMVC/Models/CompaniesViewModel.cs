using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models
{
    public class CompaniesViewModel
    {
        public long Id { get; set; }
        [Display(Name = "Количество работников")]
        public int EmployeesCount { get; set; }
        [Display(Name = "Название компании")]
        public string Name { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
    }
}