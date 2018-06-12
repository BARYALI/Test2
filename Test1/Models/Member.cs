using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string FirstName {get;set;}
         
        public string LastName { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        //Navigation Property

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }

    }
}