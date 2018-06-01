using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Test1.Models
{

    public class ParkedVehicle
    {
        public int Id { get; set; }
        public string TypeOfVehicle { get; set; }
        public string RegNo { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public string Description { get; set; }
        public DateTime ParkingTime { get; set; }

       
    }

}








