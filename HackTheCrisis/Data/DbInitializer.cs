using HackTheCrisis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HackTheCrisis.Models.HealthCareUnit;
using static HackTheCrisis.Models.Need;
using static HackTheCrisis.Models.Offer;

namespace HackTheCrisis.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            var seed = false;

            if (!seed)
                return; // DB has been seeded

            var molnlyckeHealthCareUnit = new HealthCareUnit()
            {
                UnitName = "Ortens vårdcentral",
                UnitType = HeltCareUnitType.Hospital,
                StreetAddress = "Ekdalavägen 2",
                PostalCode = 43530,
                City = "Lillorten",
                Email = "test@vgregion.se",
                ContactPerson = "Oscar Andersson",
                PhoneNumber = 0104733610
            };

            var ostraHealthCareUnit = new HealthCareUnit()
            {
                UnitName = "Västra sjukhuset",
                UnitType = HeltCareUnitType.Hospital,
                StreetAddress = "Grå stråket",
                PostalCode = 41685,
                City = "Småstad",
                Email = "test@vgregion.se",
                ContactPerson = "Livia Hirst",
                PhoneNumber = 0313421000
            };

            var sasHealthCareUnit = new HealthCareUnit()
            {
                UnitName = "Sjukhuset 1",
                UnitType = HeltCareUnitType.Hospital,
                StreetAddress = "Brämhultsvägen 53",
                PostalCode = 50182,
                City = "Borås",
                Email = "test@vgregion.se",
                ContactPerson = "Lucca Mill",
                PhoneNumber = 0336161000
            };

            context.HealthCareUnits.Add(molnlyckeHealthCareUnit);
            context.HealthCareUnits.Add(ostraHealthCareUnit);
            context.HealthCareUnits.Add(sasHealthCareUnit);

            var volvoIndustrialPartner = new IndustrialPartner()
            {
                CompanyName = "Trucktillverkaren",
                CorporateIdentityNumber = "123456789123",
                StreetAddress = "Gropegårdsgatan 2",
                PostalCode = 41715,
                City = "Göteborg",
                Email = "test@volvo.se",
                ContactPerson = "Danika Villarreal",
                PhoneNumber = 12345689,
            };

            var fraktbolagetIndustrialPartner = new IndustrialPartner()
            {
                CompanyName = "Fraktbolaget AB",
                CorporateIdentityNumber = "9988123741",
                StreetAddress = "Pedagogen Park, Prästgårdsgatan 32",
                PostalCode = 43144,
                City = "Mölndal",
                Email = "test@fraktbolaget.se",
                ContactPerson = "Roger Adam Persson",
                PhoneNumber = 55564123,
            };

            context.IndustrialPartners.Add(volvoIndustrialPartner);
            context.IndustrialPartners.Add(fraktbolagetIndustrialPartner);

            var munskyddNeed = new Need
            {
                //SubmittedDate = DateTime.Now.AddDays(-15), TODO: Ta tillbaka SubmittedDate
                DeliveryDate = DateTime.Now.AddDays(1),
                Description = "Munskydd",
                EnumNeedType = NeedType.Munskydd,
                Owner = molnlyckeHealthCareUnit,
                Quantity = 300,
                QuantityUnit = "st"
            };

            var handspritNeed = new Need
            {
                //SubmittedDate = DateTime.Now, TODO: Ta tillbaka SubmittedDate
                DeliveryDate = DateTime.Now.AddDays(20),
                Description = "Handsprit",
                EnumNeedType = NeedType.Handsprit,
                Owner = ostraHealthCareUnit,
                Quantity = 10000.5f,
                QuantityUnit = "cl"
            };

            var respiratorNeed = new Need
            {
                //SubmittedDate = DateTime.Now.AddDays(-5), TODO: Ta tillbaka SubmittedDate
                DeliveryDate = DateTime.Now.AddDays(50),
                Description = "Respirator",
                EnumNeedType = NeedType.Respirator,
                Owner = sasHealthCareUnit,
                Quantity = 40,
                QuantityUnit = "st"
            };

            context.Needs.Add(munskyddNeed);
            context.Needs.Add(handspritNeed);
            context.Needs.Add(respiratorNeed);

            var visirOffer = new Offer
            {
                //SubmittedDate = DateTime.Now.AddDays(-10),
                Description = "Visir",
                OfferTypes = OfferType.ComponentProduction,
                Type = IndustrialPartnerType.ManufacturingIndustry,
                Owner = volvoIndustrialPartner
            };

            var transportOffer = new Offer
            {
                //SubmittedDate = DateTime.Now.AddDays(-10),
                Description = "Godstransport",
                OfferTypes = OfferType.TransportLogistics,
                Type = IndustrialPartnerType.LogisticsAndTransport,
                Owner = fraktbolagetIndustrialPartner
            };

            context.Offers.Add(visirOffer);
            context.Offers.Add(transportOffer);
            
            context.SaveChanges();
        }

    }
}
