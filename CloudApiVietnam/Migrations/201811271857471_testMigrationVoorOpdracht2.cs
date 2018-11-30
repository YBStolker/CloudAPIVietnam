namespace CloudApiVietnam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testMigrationVoorOpdracht2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulierens", "test", c => c.Int(nullable: false));
            DropColumn("dbo.FormContents", "Test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FormContents", "Test", c => c.String());
            DropColumn("dbo.Formulierens", "test");
        }
    }
}
