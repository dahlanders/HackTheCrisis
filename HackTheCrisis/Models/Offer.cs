using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models
{
    public class Offer
    {
        public int OfferID { get; set; }
        public OfferType OfferTypes { get; set; }
        public string Description { get; set; }
        public IndustrialPartner Owner { get; set; }
        //public IndustrialPartnerType Type { get; set; }
        //public DateTime SubmittedDate { get; set; }
        public EnumOfferStatus OfferStatus { get; set; }
        public float Quantity { get; set; }
        public string QuantityUnit { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeliveryDate { get; set; }
        public enum EnumOfferStatus
        {
            Overifierat,
            Publicerat,
            Utnyttjat,
            DelvisUtnyttjat,
            Borttaget,
        }
        public enum OfferType
        {
            IndustrialProduction,
            ComponentProduction,
            TransportLogistics,
            StorageSpace,
            ProductBlueprintAndIpRights,
            Other,
        }
        public enum IndustrialPartnerType
        {
            ManufacturingIndustry,
            Subcontractor,
            LogisticsAndTransport,
            Warehouse,
        }

    }
}
