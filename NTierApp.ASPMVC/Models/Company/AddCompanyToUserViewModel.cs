﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models.Company
{
    public class AddCompanyToUserViewModel
    {
        public long UserId { get; set; }
        public long CompanyId { get; set; }
    }
}