namespace Infirmary_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class h : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Salary", c => c.Int(nullable: false));
            AddColumn("dbo.People", "MatherName", c => c.String());
            AddColumn("dbo.People", "Address", c => c.String());
            AddColumn("dbo.People", "RelativeNumber", c => c.String());
            AddColumn("dbo.People", "Notes", c => c.String());
            AddColumn("dbo.People", "Image", c => c.String());
            AddColumn("dbo.People", "Photo", c => c.String());
            AddColumn("dbo.Reports", "IdPerson", c => c.Int(nullable: false));
            AddColumn("dbo.Reports", "Person_Id", c => c.Int());
            AddColumn("dbo.PersonJobs", "FinSalary", c => c.Int(nullable: false));
            CreateIndex("dbo.Reports", "Person_Id");
            AddForeignKey("dbo.Reports", "Person_Id", "dbo.People", "Id");
            DropColumn("dbo.Reports", "Amount");
            DropColumn("dbo.PersonJobs", "Salary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonJobs", "Salary", c => c.Int(nullable: false));
            AddColumn("dbo.Reports", "Amount", c => c.Int(nullable: false));
            DropForeignKey("dbo.Reports", "Person_Id", "dbo.People");
            DropIndex("dbo.Reports", new[] { "Person_Id" });
            DropColumn("dbo.PersonJobs", "FinSalary");
            DropColumn("dbo.Reports", "Person_Id");
            DropColumn("dbo.Reports", "IdPerson");
            DropColumn("dbo.People", "Photo");
            DropColumn("dbo.People", "Image");
            DropColumn("dbo.People", "Notes");
            DropColumn("dbo.People", "RelativeNumber");
            DropColumn("dbo.People", "Address");
            DropColumn("dbo.People", "MatherName");
            DropColumn("dbo.Jobs", "Salary");
        }
    }
}
