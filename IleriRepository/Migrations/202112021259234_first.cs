namespace IleriRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.County",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EducationId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Street = c.String(),
                        Avenue = c.String(),
                        HouseNumber = c.String(),
                        CountyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.County", t => t.CountyId, cascadeDelete: true)
                .ForeignKey("dbo.Education", t => t.EducationId, cascadeDelete: true)
                .Index(t => t.EducationId)
                .Index(t => t.CountyId);
            
            CreateTable(
                "dbo.Education",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcademicTitle = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Branch = c.String(),
                        EducationId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Street = c.String(),
                        Avenue = c.String(),
                        HouseNumber = c.String(),
                        CountyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.County", t => t.CountyId, cascadeDelete: true)
                .ForeignKey("dbo.Education", t => t.EducationId, cascadeDelete: true)
                .Index(t => t.EducationId)
                .Index(t => t.CountyId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EducationId = c.Int(nullable: false),
                        LecturerId = c.Int(),
                        UniversityDep = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Street = c.String(),
                        Avenue = c.String(),
                        HouseNumber = c.String(),
                        CountyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.County", t => t.CountyId, cascadeDelete: true)
                .ForeignKey("dbo.Education", t => t.EducationId, cascadeDelete: true)
                .ForeignKey("dbo.Lecturer", t => t.LecturerId)
                .Index(t => t.EducationId)
                .Index(t => t.LecturerId)
                .Index(t => t.CountyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "LecturerId", "dbo.Lecturer");
            DropForeignKey("dbo.Students", "EducationId", "dbo.Education");
            DropForeignKey("dbo.Students", "CountyId", "dbo.County");
            DropForeignKey("dbo.Lecturer", "EducationId", "dbo.Education");
            DropForeignKey("dbo.Lecturer", "CountyId", "dbo.County");
            DropForeignKey("dbo.Employees", "EducationId", "dbo.Education");
            DropForeignKey("dbo.Employees", "CountyId", "dbo.County");
            DropForeignKey("dbo.County", "CityId", "dbo.City");
            DropIndex("dbo.Students", new[] { "CountyId" });
            DropIndex("dbo.Students", new[] { "LecturerId" });
            DropIndex("dbo.Students", new[] { "EducationId" });
            DropIndex("dbo.Lecturer", new[] { "CountyId" });
            DropIndex("dbo.Lecturer", new[] { "EducationId" });
            DropIndex("dbo.Employees", new[] { "CountyId" });
            DropIndex("dbo.Employees", new[] { "EducationId" });
            DropIndex("dbo.County", new[] { "CityId" });
            DropTable("dbo.Students");
            DropTable("dbo.Lecturer");
            DropTable("dbo.Education");
            DropTable("dbo.Employees");
            DropTable("dbo.County");
            DropTable("dbo.City");
        }
    }
}
