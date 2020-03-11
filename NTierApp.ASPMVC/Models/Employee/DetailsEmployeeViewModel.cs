using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models
{
    public class DetailsEmployeeViewModel
    {
        public long Id { get; set; }
        [Display(Name = "Полное имя")]
        public string FullName { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Компании")]
        public ICollection<CompanyBLL> Companies { get; set; }
    }
}