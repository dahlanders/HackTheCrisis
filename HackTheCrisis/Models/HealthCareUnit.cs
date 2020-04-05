using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class HealthCareUnit : ContactDetails
    {
        [Key]
        public int HealthCareUnitID { get; set; }
        public string UnitName { get; set; }
        public HeltCareUnitType UnitType { get; set; }
        public string ContactPerson { get; set; }

        public List<Need> Needs { get; set; }
    }
}
