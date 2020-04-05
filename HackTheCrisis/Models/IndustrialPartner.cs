using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class IndustrialPartner
    {
        public int IndustrialPartnerID { get; set; }
        public string CorporateIdentityNumber { get; set; }
        public string CompanyName { get; set; }
        public ContactDetails Address { get; set; }
        public string ContactPerson { get; set; }
        public List<Offer> Offers { get; set; }

    }
}
