using HackTheCrisis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            //var seed = false;

            //if (!seed)
            //    return; // DB has been seeded

            //var molnlyckeHealthCareUnit = new HealthCareUnit()
            //{
            //    UnitName = "Mölnlycke vårdcentral",
            //    UnitType = HeltCareUnitType.Hospital,
            //    Address = new Address
            //    {
            //        StreetAddress = "Ekdalavägen 2 Närhälsan Mölnlycke Vårdcentral",
            //        PostalCode = 43530,
            //        City = "Mölnlycke",
            //    },
            //    Email = "test@vgregion.se",
            //    ContactPerson = "Emil Karlsson",
            //    PhoneNumber = 0104733610
            //};

            //var ostraHealthCareUnit = new HealthCareUnit()
            //{
            //    UnitName = "Östra sjukhuset",
            //    UnitType = HeltCareUnitType.Hospital,
            //    Address = new Address
            //    {
            //        StreetAddress = "Sahlgrenska Universitetssjukhuset Östra sjukhuset",
            //        PostalCode = 41685,
            //        City = "Göteborg ",
            //    },
            //    Email = "test@vgregion.se",
            //    ContactPerson = "Emil Karlsson",
            //    PhoneNumber = 0313421000
            //};

            //var sasHealthCareUnit = new HealthCareUnit()
            //{
            //    UnitName = "Södra Älvsborgs Sjukhus",
            //    UnitType = HeltCareUnitType.Hospital,
            //    Address = new Address
            //    {
            //        StreetAddress = "Brämhultsvägen 53 Södra Älvsborgs Sjukhus",
            //        PostalCode = 50182,
            //        City = "Borås ",
            //    },
            //    Email = "test@vgregion.se",
            //    ContactPerson = "Emil Karlsson",
            //    PhoneNumber = 0336161000
            //};

            //context.HealthCareUnits.Add(molnlyckeHealthCareUnit);
            //context.HealthCareUnits.Add(ostraHealthCareUnit);
            //context.HealthCareUnits.Add(sasHealthCareUnit);
            


            //var volvoIndustrialPartner = new IndustrialPartner()
            //{
            //    CompanyName = "Volvo trucks",
            //    CorporateIdentityNumber = "123456789123",
            //    Address = new Address
            //    {
            //        StreetAddress = "Gropegårdsgatan 2",
            //        PostalCode = 41715,
            //        City = "Göteborg",
            //    },
            //    Email = "test@volvo.se",
            //    ContactPerson = "Emil Karlsson",
            //    PhoneNumber = 12345689,
            //};

            // var fraktbolagetIndustrialPartner = new IndustrialPartner()
            //{
            //    CompanyName = "Volvo trucks",
            //    CorporateIdentityNumber = "123456789123",
            //    Address = new Address
            //    {
            //        StreetAddress = "Gropegårdsgatan 2",
            //        PostalCode = 41715,
            //        City = "Göteborg",
            //    },
            //    Email = "test@volvo.se",
            //    ContactPerson = "Emil Karlsson",
            //    PhoneNumber = 12345689,
            //};





            //var molnlyckeHealthCareUnit = new HealthCareUnit()
            //{
            //    UnitName = "Mölnlycke vårdcentral",
            //    UnitType = "Vårdcentral"
            //};


            //var demands = context.Demands.Include(o => o.HealthCareUnit).ToList();

            //var demandSpace = new Demand()
            //{
            //    Item = "Rymdskepp",
            //    Quantity = 3,
            //    WhenDoINeedIt = DateTime.Now.AddDays(30),
            //    CreatedDate = DateTime.Now.AddMinutes(10),
            //    HealthCareUnit = testUnit,
            //};


            //context.HealthCareUnits.Add(sosHealthCareUnit);
            //context.SaveChanges();

            //var demands = context.Demands.Include(o => o.HealthCareUnit).ToList();

            //// Add demands
            //var demandMunskydd = new Demand()
            //{
            //    Item = "Munskydd",
            //    Quantity = 300,
            //    WhenDoINeedIt = DateTime.Now,
            //    CreatedDate = DateTime.Now,
            //    HealthCareUnit = molnlyckeHealthCareUnit,
            //};

            //context.Demands.Add(demandMunskydd);
            //context.SaveChanges();

        }

    }
}
