using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppEntityFrameworkLesson.Models
{
    [Table("Users")]
    class User
    {
        public int Id { get; set; }
        [Unique]
        public string Login { get; set; }
        [Unique]
        public string Email { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
