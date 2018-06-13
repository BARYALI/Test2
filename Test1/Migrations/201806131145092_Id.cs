namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Id : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ParkedVehicles", "Members_memberId", "dbo.Members");
            DropIndex("dbo.ParkedVehicles", new[] { "Members_memberId" });
            DropPrimaryKey("dbo.Members");
            AlterColumn("dbo.Members", "memberId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ParkedVehicles", "Members_memberId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Members", "memberId");
            CreateIndex("dbo.ParkedVehicles", "Members_memberId");
            AddForeignKey("dbo.ParkedVehicles", "Members_memberId", "dbo.Members", "memberId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkedVehicles", "Members_memberId", "dbo.Members");
            DropIndex("dbo.ParkedVehicles", new[] { "Members_memberId" });
            DropPrimaryKey("dbo.Members");
            AlterColumn("dbo.ParkedVehicles", "Members_memberId", c => c.Int());
            AlterColumn("dbo.Members", "memberId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Members", "memberId");
            CreateIndex("dbo.ParkedVehicles", "Members_memberId");
            AddForeignKey("dbo.ParkedVehicles", "Members_memberId", "dbo.Members", "memberId");
        }
    }
}
