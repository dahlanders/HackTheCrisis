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
        //public static void Initialize(ApplicationDbContext context)
        //{
        //    context.Database.EnsureCreated();

        //    // Look for any demands
        //    if (context.Demands.Any())
        //    {
        //        return;   // DB has been seeded
        //    }

        //    // Add health care unit
        //    var allDemands = context.Demands.ToList();
        //    var allHealthCareUnits = context.HealthCareUnits.ToList();

        //    var testUnitName = "Lucas vårdcentral";
        //    var testUnit = context.HealthCareUnits.FirstOrDefault(x => x.UnitName == testUnitName);

        //    // If the test health care unit doesn't exist
        //    if (testUnit == null)
        //    {
        //        var healthCareUnit = new HealthCareUnit()
        //        {
        //            UnitName = testUnitName,
        //            UnitType = "Primärvård"
        //        };

        //        context.HealthCareUnits.Add(healthCareUnit);
        //        context.SaveChanges();
        //    }


        //    // Add demand
        //    var demands = context.Demands.Include(o => o.HealthCareUnit).ToList();

        //    var demandPotatos = new Demand()
        //    {
        //        Item = "Säck potatis",
        //        Quantity = 10,
        //        WhenDoINeedIt = DateTime.Now.AddDays(10),
        //        CreatedDate = DateTime.Now,
        //        HealthCareUnit = testUnit,
        //    };

        //    var demandSpace = new Demand()
        //    {
        //        Item = "Rymdskepp",
        //        Quantity = 3,
        //        WhenDoINeedIt = DateTime.Now.AddDays(30),
        //        CreatedDate = DateTime.Now.AddMinutes(10),
        //        HealthCareUnit = testUnit,
        //    };

        //    context.Demands.Add(demandPotatos);
        //    context.Demands.Add(demandSpace);
        //    context.SaveChanges();

        //}

    }
}
