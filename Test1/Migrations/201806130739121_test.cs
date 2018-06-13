namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        memberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        address = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.memberId);
            
            CreateTable(
                "dbo.ParkedVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfVehicle = c.String(),
                        RegNo = c.String(),
                        Color = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        NoOfWheels = c.Int(nullable: false),
                        Description = c.String(),
                        ParkingTime = c.DateTime(nullable: false),
                        Members_memberId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Members_memberId)
                .Index(t => t.Members_memberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkedVehicles", "Members_memberId", "dbo.Members");
            DropIndex("dbo.ParkedVehicles", new[] { "Members_memberId" });
            DropTable("dbo.ParkedVehicles");
            DropTable("dbo.Members");
        }
    }
}
