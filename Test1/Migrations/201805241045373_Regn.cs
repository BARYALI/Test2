namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Regn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "RegNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "RegNo", c => c.Int(nullable: false));
        }
    }
}
