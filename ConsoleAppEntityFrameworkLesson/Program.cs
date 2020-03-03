using ConsoleAppEntityFrameworkLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleAppEntityFrameworkLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DatabaseContext())
            {
                //Company company = new Company { Name = "Itransition" };
                //db.Companies.Add(company);

                //Employee employee = new Employee {
                //Age=21,
                //FirstName = "Max",
                //LastName = "Yestolok"
                //};
                //employee.Companies.Add(company);
                //db.Employees.Add(employee);

                //db.SaveChanges();

                db.Users.Add(new User {Email="max@gmail.com", Login = "logIn" });
                db.Users.Add(new User {Email="pewds@gmail.com", Login = "pewd" });
                db.Admins.Add(new Admin { HasSpecialPermissions = true, Email = "adm@gmail.com", Login = "sucker" });
                db.Admins.Add(new Admin { HasSpecialPermissions = false, Email = "admMax@gmail.com", Login = "fucker" });
                db.SaveChanges();
            }
            using (var db = new DatabaseContext())
            {
                //var employees = db.Employees.Include(c=>c.Company).ToList(); // жадная подгрузка
                //var companies = db.Companies.ToList();
                //var employees = db.Companies.First().Employees.ToList(); //ленивая
                //var count = db.Companies.Select(p => new { p.Name, count = p.Employees.Count() }).ToList();
                IQueryable<User> users = db.Users;
                users = users.Where(p => p.Login.StartsWith("A"));
                users = users.Where(p => p.Email.EndsWith(".com"));
                var result = users.ToList();


                IEnumerable<User> newUsers = db.Users;
                newUsers = newUsers.Where(p => p.Login.StartsWith("A"));
                newUsers = newUsers.Where(p => p.Email.EndsWith(".com"));
                var newResult = newUsers.ToList();
            }
        }
    }
}
