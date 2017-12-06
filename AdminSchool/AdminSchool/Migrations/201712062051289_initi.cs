namespace AdminSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SchoolTeachers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SchoolTeachers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SchoolTeachers", "Position", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Sports", "Football", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Sports", "Basketball", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Sports", "Tennis", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Sports", "Hoky", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Sports", "Ragkpi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.StudentDatas", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.StudentDatas", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentDatas", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentDatas", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Sports", "Ragkpi", c => c.String(nullable: false));
            AlterColumn("dbo.Sports", "Hoky", c => c.String(nullable: false));
            AlterColumn("dbo.Sports", "Tennis", c => c.String(nullable: false));
            AlterColumn("dbo.Sports", "Basketball", c => c.String(nullable: false));
            AlterColumn("dbo.Sports", "Football", c => c.String(nullable: false));
            AlterColumn("dbo.SchoolTeachers", "Position", c => c.String(nullable: false));
            AlterColumn("dbo.SchoolTeachers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.SchoolTeachers", "FirstName", c => c.String(nullable: false));
        }
    }
}
