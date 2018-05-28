namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up() => DropColumn("dbo.ParkedVehicles", "RegNo");

        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "RegNo", c => c.String());
        }
    }
}
