using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class ContactDetails
    {
        public Address Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
