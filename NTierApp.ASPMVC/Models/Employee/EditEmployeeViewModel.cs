﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC.Models
{
    public class EditEmployeeViewModel
    {
        public long Id { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
    }
}