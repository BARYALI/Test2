using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class VehicleType
    {
        public int Type_id { get; set; }

        public string VehicleTypeName { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }

    }
}