using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test1.DataAccessLayer
{
   
        public class StorageContext : DbContext
        {
            public StorageContext() : base("Test1")
            {

            }
            public DbSet<Models.ParkedVehicle> ParkedVehicles { get; set; }
        }

    
}



