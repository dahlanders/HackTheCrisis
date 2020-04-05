using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HackTheCrisis.Models;

namespace HackTheCrisis.Models
{
    public class Need
    {
        [Key]
        public int NeedID { get; set; }
        public EnumNeedType enumNeedType { get; set; }
        public string Description { get; set; }
        [Range(0, 10000, ErrorMessage = "Du har angiviet ett högt värde")]
        public float Quantity { get; set; }
        [Required]
        public string QuantityUnit { get; set; }
        
        public DateTime DeliveryDate { get; set; }
        [Required]
        public HealthCareUnit Owner { get; set; }
      
        public IndustrialPartner Matchning { get; set; }

        
        public DateTime CreatedDate { get; set; }
    }
}
