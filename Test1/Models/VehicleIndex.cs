using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Test1.Models
{
    public class VehicleIndex
    {
        
        public int Id { get; set; }
        public int RegNo { get; set; }
        public string Color { get; set; }
       public string Type { get; set; }
        public string Brand { get; set; }
       public DateTime ParkingTime { get; set; }

        public VehicleIndex(VehicleIndex e)
        {

            Id = e.Id;
            RegNo = e.RegNo;
            Color = e.Color;
            Type = e.Type;
            Brand = e.Brand;
           ParkingTime = e.ParkingTime;
        }

        public VehicleIndex(int id, int regNo,string color, string brand,string type)
        {
           Id = id;
           RegNo = regNo;
           Color = color;
           Type = type;
           Brand = brand;
        }
        


    }
}