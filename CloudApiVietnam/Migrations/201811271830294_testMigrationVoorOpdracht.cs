namespace CloudApiVietnam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testMigrationVoorOpdracht : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormContents", "Test", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FormContents", "Test");
        }
    }
}
