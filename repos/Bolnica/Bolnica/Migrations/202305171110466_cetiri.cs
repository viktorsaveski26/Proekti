namespace Bolnica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cetiri : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pacietns", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pacietns", "Name", c => c.String());
        }
    }
}
