using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFrameworkLesson.Models
{
    [Table("Admins")]
    class Admin :User
    {
        public bool HasSpecialPermissions { get; set; }
    }
}
