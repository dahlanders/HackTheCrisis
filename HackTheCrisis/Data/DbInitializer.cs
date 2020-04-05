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

            var seed = false;

            if (!seed)
                return; // DB has been seeded

            // Add health care unit
            var allDemands = context.Demands.ToList();
            var allHealthCareUnits = context.HealthCareUnits.ToList();


            var molnlyckeHealthCareUnit = new HealthCareUnit()
            {
                UnitName = "Mölnlycke vårdcentral",
                UnitType = "Vårdcentral"
            };

            var sosHealthCareUnit = new HealthCareUnit()
            {
                UnitName = "SÖS",
                UnitType = "Primärvård"
            };

            context.HealthCareUnits.Add(molnlyckeHealthCareUnit);
            context.HealthCareUnits.Add(sosHealthCareUnit);
            context.SaveChanges();
            
            var demands = context.Demands.Include(o => o.HealthCareUnit).ToList();

             // Add demands
            var demandMunskydd = new Demand()
            {
                Item = "Munskydd",
                Quantity = 300,
                WhenDoINeedIt = DateTime.Now,
                CreatedDate = DateTime.Now,
                HealthCareUnit = molnlyckeHealthCareUnit,
            };

            var demandRespiratorer = new Demand()
            {
                Item = "Respiratorer",
                Quantity = 40,
                WhenDoINeedIt = DateTime.Now.AddDays(30),
                CreatedDate = DateTime.Now.AddMinutes(50),
                HealthCareUnit = sosHealthCareUnit,
            };

            context.Demands.Add(demandMunskydd);
            context.Demands.Add(demandRespiratorer);
            context.SaveChanges();

        }

    }
}
