using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HackTheCrisis.Models;

namespace HackTheCrisis.Models
{
    public class Demand
    {
        [Key]
        public int DemandID { get; set; }
        [Required]
        public string Item { get; set; }
        public int Quantity { get; set; }
        public DateTime WhenDoINeedIt { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        public HealthCareUnit HealthCareUnit { get; set; }
    }
}
