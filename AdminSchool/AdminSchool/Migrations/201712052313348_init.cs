namespace AdminSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentDatas", "FavouritTopic", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentDatas", "FavouritTopic", c => c.String(nullable: false));
        }
    }
}
