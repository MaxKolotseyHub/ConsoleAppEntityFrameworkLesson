using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Models
{
    public class EmployeeBLL
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public ICollection<CompanyBLL> Companies { get; set; }
    }
}
