namespace AdminSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchoolTeachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Position = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Football = c.String(nullable: false),
                        Basketball = c.String(nullable: false),
                        Tennis = c.String(nullable: false),
                        Hoky = c.String(nullable: false),
                        Ragkpi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        SchoolClass = c.Int(nullable: false),
                        FavouritTopic = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentDatas");
            DropTable("dbo.Sports");
            DropTable("dbo.SchoolTeachers");
        }
    }
}
