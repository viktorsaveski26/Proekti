namespace Bolnica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tri : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacietns", "Pol", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pacietns", "Pol");
        }
    }
}
