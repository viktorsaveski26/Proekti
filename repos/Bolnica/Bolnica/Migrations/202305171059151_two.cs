namespace Bolnica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Bolnicas", newName: "Bolnicaas");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Bolnicaas", newName: "Bolnicas");
        }
    }
}
