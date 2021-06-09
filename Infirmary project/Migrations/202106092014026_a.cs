namespace Infirmary_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EntrySides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HealthStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Int(nullable: false),
                        IdCategory = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        IdPersonHealthStatus = c.Int(nullable: false),
                        IdReportMaterial = c.Int(nullable: false),
                        PersonHealthStatus_Id = c.Int(),
                        ReportMaterial_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonHealthStatus", t => t.PersonHealthStatus_Id)
                .ForeignKey("dbo.ReportMaterials", t => t.ReportMaterial_Id)
                .Index(t => t.PersonHealthStatus_Id)
                .Index(t => t.ReportMaterial_Id);
            
            CreateTable(
                "dbo.PersonHealthStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        IdPerson = c.Int(nullable: false),
                        IdHealthStatus = c.Int(nullable: false),
                        HealthStatus_Id = c.Int(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HealthStatus", t => t.HealthStatus_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.HealthStatus_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        CivilianId = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReportMaterials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        IdReport = c.Int(nullable: false),
                        IdMaterial = c.Int(nullable: false),
                        Material_Id = c.Int(),
                        Report_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id)
                .ForeignKey("dbo.Reports", t => t.Report_Id)
                .Index(t => t.Material_Id)
                .Index(t => t.Report_Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Amount = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        IdPerson = c.Int(nullable: false),
                        IdJob = c.Int(nullable: false),
                        Job_Id = c.Int(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.Job_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Job_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.PersonStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Date = c.DateTime(nullable: false),
                        IdPerson = c.Int(nullable: false),
                        IdEntrySide = c.Int(nullable: false),
                        EntrySide_Id = c.Int(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EntrySides", t => t.EntrySide_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.EntrySide_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonStatus", "Person_Id", "dbo.People");
            DropForeignKey("dbo.PersonStatus", "EntrySide_Id", "dbo.EntrySides");
            DropForeignKey("dbo.PersonJobs", "Person_Id", "dbo.People");
            DropForeignKey("dbo.PersonJobs", "Job_Id", "dbo.Jobs");
            DropForeignKey("dbo.Medicines", "ReportMaterial_Id", "dbo.ReportMaterials");
            DropForeignKey("dbo.ReportMaterials", "Report_Id", "dbo.Reports");
            DropForeignKey("dbo.ReportMaterials", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.Medicines", "PersonHealthStatus_Id", "dbo.PersonHealthStatus");
            DropForeignKey("dbo.PersonHealthStatus", "Person_Id", "dbo.People");
            DropForeignKey("dbo.PersonHealthStatus", "HealthStatus_Id", "dbo.HealthStatus");
            DropForeignKey("dbo.Materials", "Category_Id", "dbo.Categories");
            DropIndex("dbo.PersonStatus", new[] { "Person_Id" });
            DropIndex("dbo.PersonStatus", new[] { "EntrySide_Id" });
            DropIndex("dbo.PersonJobs", new[] { "Person_Id" });
            DropIndex("dbo.PersonJobs", new[] { "Job_Id" });
            DropIndex("dbo.ReportMaterials", new[] { "Report_Id" });
            DropIndex("dbo.ReportMaterials", new[] { "Material_Id" });
            DropIndex("dbo.PersonHealthStatus", new[] { "Person_Id" });
            DropIndex("dbo.PersonHealthStatus", new[] { "HealthStatus_Id" });
            DropIndex("dbo.Medicines", new[] { "ReportMaterial_Id" });
            DropIndex("dbo.Medicines", new[] { "PersonHealthStatus_Id" });
            DropIndex("dbo.Materials", new[] { "Category_Id" });
            DropTable("dbo.PersonStatus");
            DropTable("dbo.PersonJobs");
            DropTable("dbo.Reports");
            DropTable("dbo.ReportMaterials");
            DropTable("dbo.People");
            DropTable("dbo.PersonHealthStatus");
            DropTable("dbo.Medicines");
            DropTable("dbo.Materials");
            DropTable("dbo.Jobs");
            DropTable("dbo.HealthStatus");
            DropTable("dbo.EntrySides");
            DropTable("dbo.Categories");
        }
    }
}
