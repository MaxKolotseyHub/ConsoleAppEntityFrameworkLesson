namespace ConsoleAppEntityFrameworkLesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyEmployee",
                c => new
                    {
                        EmployeeId = c.Long(nullable: false),
                        CompanyId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeId, t.CompanyId })
                .ForeignKey("dbo.Companies", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        HasSpecialPermissions = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "Id", "dbo.Users");
            DropForeignKey("dbo.CompanyEmployee", "CompanyId", "dbo.Employees");
            DropForeignKey("dbo.CompanyEmployee", "EmployeeId", "dbo.Companies");
            DropForeignKey("dbo.UserProfiles", "Id", "dbo.Users");
            DropIndex("dbo.Admins", new[] { "Id" });
            DropIndex("dbo.CompanyEmployee", new[] { "CompanyId" });
            DropIndex("dbo.CompanyEmployee", new[] { "EmployeeId" });
            DropIndex("dbo.UserProfiles", new[] { "Id" });
            DropTable("dbo.Admins");
            DropTable("dbo.CompanyEmployee");
            DropTable("dbo.Employees");
            DropTable("dbo.Companies");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Users");
        }
    }
}
