using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models
{
    public class DetailsEmployeeViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public ICollection<CompanyBLL> Companies { get; set; }
    }
}