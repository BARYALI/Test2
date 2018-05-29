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
        //[Required(AllowEmptyStrings = false, ErrorMessage = "You hav to write the exacte name of colors not numbers")]
       // [StringLength(15, MinimumLength = 2, ErrorMessage = "Name muste be between 2 alnd longer")]
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public string Description { get; set; }
        public DateTime ParkingTime { get; set; }

       
    }

}








