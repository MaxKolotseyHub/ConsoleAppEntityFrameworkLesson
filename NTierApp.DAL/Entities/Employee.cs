using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Entities
{
    public class Employee
    {
        public Employee()
        {
            Companies = new List<Company>();    
        }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
