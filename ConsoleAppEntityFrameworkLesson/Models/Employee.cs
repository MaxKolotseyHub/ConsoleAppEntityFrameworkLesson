using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFrameworkLesson.Models
{
    class Employee
    {
        public Employee()
        {
            Companies = new List<Company>();
        }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public long CompanyId { get; set; } //Навигационное свойство
        public  ICollection<Company> Companies { get; set; }
    }
}
