namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class time : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "ParkingTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.ParkedVehicles", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.ParkedVehicles", "ParkingTime");
        }
    }
}
