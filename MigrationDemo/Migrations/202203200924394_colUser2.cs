namespace MigrationDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class colUser2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "User2", c => c.Int(nullable: false));          
        }
        
        public override void Down()
        {          
            DropColumn("dbo.Blogs", "User2");
        }
    }
}
