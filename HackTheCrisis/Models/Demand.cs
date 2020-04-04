using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Range(0, 10000, ErrorMessage = "Du har angiviet ett högt värde")]
        public int Quantity { get; set; }
        public DateTime WhenDoINeedIt { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        public HealthCareUnit HealthCareUnit { get; set; }
    }
}
