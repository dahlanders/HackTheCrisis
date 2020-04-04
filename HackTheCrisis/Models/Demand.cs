using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTheCrisis.Models;

namespace HackTheCrisis.Models
{
    public class Demand
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public DateTime WhenDoINeedIt { get; set; }
        public HealthCareUnit HealthCareUnit { get; set; }
    }
}
