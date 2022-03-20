namespace MigrationDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "ColUser1", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "ColUser1");
        }
    }
}
