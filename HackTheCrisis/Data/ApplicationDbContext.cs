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
        public DbSet<Demand> Demands { get; set; }
        public DbSet<HealthCareUnit> HealthCareUnits { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
