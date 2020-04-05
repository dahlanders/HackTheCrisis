using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class Delivery
    {
        public float Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
