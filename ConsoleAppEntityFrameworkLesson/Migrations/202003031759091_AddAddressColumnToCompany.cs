﻿namespace ConsoleAppEntityFrameworkLesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressColumnToCompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "Address");
        }
    }
}
