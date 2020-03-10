using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models
{
    public class EmployeesViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}