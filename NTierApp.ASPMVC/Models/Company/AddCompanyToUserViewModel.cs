using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models.Company
{
    public class AddCompanyToUserViewModel
    {
        public int UserId { get; set; }
        public int CompanyId { get; set; }
    }
}