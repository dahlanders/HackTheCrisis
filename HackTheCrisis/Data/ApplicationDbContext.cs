using System;
using System.Collections.Generic;
using System.Text;
using HackTheCrisis.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HackTheCrisis.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Need> Needs { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<HealthCareUnit> HealthCareUnits { get; set; }
           
        public DbSet<IndustrialPartner> IndustrialPartners { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
