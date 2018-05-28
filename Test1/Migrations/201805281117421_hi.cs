namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String());
        }
    }
}
