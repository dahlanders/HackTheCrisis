using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class HealthCareUnit
    {
        [Key]
        public int HealthCareUnitID { get; set; }
        [Required]
        public string UnitName { get; set; }
        [Required]
        public string UnitType { get; set; }

        public List<Demand> Demands { get; set; }
    }
}
