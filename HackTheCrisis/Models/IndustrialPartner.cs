using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class IndustrialPartner : ContactDetails
    {
        [Key]
        public int IndustrialPartnerID { get; set; }
        public string CorporateIdentityNumber { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        
        public List<Offer> Offers { get; set; }

    }
}
