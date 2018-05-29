namespace Test1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Test1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Test1.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Test1.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            ParkedVehicle chacha = new ParkedVehicle()
            {
                TypeOfVehicle = "car",
                RegNo = "123",
               
                Color = "worker",
                Brand = "kabul",
                Model = "zbe",
                NoOfWheels = 4,
                Description = "black",
                ParkingTime = DateTime.Now
               
            };

            context.ParkedVehicles.AddOrUpdate(t => t.RegNo, chacha);
            


        }


    }
}
