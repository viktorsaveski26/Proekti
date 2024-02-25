namespace WebApplication33.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "MovieCard", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Address", c => c.String(nullable: false));
            DropColumn("dbo.Clients", "ClenskaKarta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "ClenskaKarta", c => c.String());
            AlterColumn("dbo.Clients", "Address", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
            DropColumn("dbo.Clients", "MovieCard");
            DropColumn("dbo.Clients", "Age");
        }
    }
}
