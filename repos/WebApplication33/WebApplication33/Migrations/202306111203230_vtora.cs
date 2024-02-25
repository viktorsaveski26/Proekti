namespace WebApplication33.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vtora : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DownloadUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DownloadUrl", c => c.String());
        }
    }
}
