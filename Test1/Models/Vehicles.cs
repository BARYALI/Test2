using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string Type { get; set; } 
        public int RegNo { get; set; }
        public string Color { get; set; } 
        public DateTime ParkingTime { get; set; }

    }
}