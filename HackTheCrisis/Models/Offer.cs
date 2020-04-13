using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class Offer
    {
        public int OfferID { get; set; }
        public OfferType OfferTypes { get; set; }
        public string Description { get; set; }
        public IndustrialPartner Owner { get; set; }
        public IndustrialPartnerType Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
