using ConsoleAppEntityFrameworkLesson.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFrameworkLesson
{
    class DatabaseContext:DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new ContextInitializer());
        }
        public DbSet<Company> Companies{ get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(p => p.Employees)//связь
                .WithMany(p => p.Companies)//многие ко многим
                .Map(x=>x.MapLeftKey("EmployeeId").MapRightKey("CompanyId").ToTable("CompanyEmployee")); //Изменение стандартных имен столбцов Fluent Api

            modelBuilder.Entity<User>()
                .Property(p => p.Login)
                .IsRequired();

            //связь один к одному Fluent Api

            modelBuilder.Entity<User>()
                .HasOptional(p => p.UserProfile)
                .WithRequired(p => p.User);
        }
    }
}
