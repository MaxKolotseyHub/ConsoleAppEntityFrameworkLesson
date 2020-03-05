using NTierApp.DAL.Entities;
using System.Data.Entity;

namespace NTierApp.DAL.Repositories
{
    public class DatabaseContext: DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new ContextInitializer());
        }
        public DatabaseContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(p => p.Employees)//связь
                .WithMany(p => p.Companies)//многие ко многим
                .Map(x => x.MapLeftKey("EmployeeId").MapRightKey("CompanyId").ToTable("CompanyEmployee")); //Изменение стандартных имен столбцов Fluent Api
        }
    }
}
