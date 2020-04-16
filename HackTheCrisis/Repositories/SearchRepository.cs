using HackTheCrisis.Data;
using HackTheCrisis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Repositories
{
    public class SearchRepository
    {
        private readonly ApplicationDbContext _context;

        public SearchRepository(ApplicationDbContext context)
        {
            _context = context;
        }

         public IEnumerable<Need> GetAllNeeds()
        {
            var needs = _context.Needs.Include(x => x.Owner);
            return needs.ToArray();
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            var offers = _context.Offers.Include(x => x.Owner);
            return offers.ToArray();
        }
    }
}
