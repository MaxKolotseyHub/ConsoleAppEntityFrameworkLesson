﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Entities
{
    public class Company
    {
        public Company()
        {
            Employees = new List<Employee>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
