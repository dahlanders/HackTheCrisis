using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class Offer
    {
        public EnumOfferType OfferTypes { get; set; }
        public string Description { get; set; }
        public IndustrialPartner Owner { get; set; }
        public EnumIndustrialPartnerType Type { get; set; }
    }
}
