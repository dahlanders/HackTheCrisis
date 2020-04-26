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
        public int NeedID { get; set; }
        public NeedType EnumNeedType { get; set; }
        public string Description { get; set; }
        [Range(0, 10000, ErrorMessage = "Du har angiviet ett högt värde")]
        public float Quantity { get; set; }
        public string QuantityUnit { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeliveryDate { get; set; }
        public HealthCareUnit Owner { get; set; }     
        public DateTime SubmittedDate { get; set; }
        public EnumNeesStatus NeesStatus { get; set; }
        public enum NeedType
        {
            Andningsskydd,
            Handsprit,
            Läkemedelspump,
            Munskydd,
            Plastförkläde,
            Respirator,
            Skyddsglasögon,
            Skyddshandskar,
            Skyddsrock,
            Visir,
            Other,
        }
        public enum EnumNeesStatus
        {
            Overifierat,
            Publicerat,
            Tillgodosett,
            Borttaget,
            DelvisTillgodosett,
        }

    }
}
