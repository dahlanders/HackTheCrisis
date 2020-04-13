using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class SearchResultViewModel
    {
        public string Organization { get; set; }
        public string Item { get; set; }
        public float Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string Location { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public HelpType HelpType { get; set; }
    }
}
