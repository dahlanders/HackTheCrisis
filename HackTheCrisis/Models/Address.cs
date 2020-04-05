using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public int PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
