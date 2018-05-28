namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rrr : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ParkedVehicles", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
