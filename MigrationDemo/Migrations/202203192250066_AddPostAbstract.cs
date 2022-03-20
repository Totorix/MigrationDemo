namespace MigrationDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostAbstract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Abstract", c => c.String());

            Sql("Update dbo.posts Set Abstract = Left(Content, 100) where Abstract is null ");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Abstract");
        }
    }
}
