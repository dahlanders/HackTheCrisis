using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackTheCrisis.Models;
using HackTheCrisis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HackTheCrisis.Helpers;
using HackTheCrisis.Repositories;
using HackTheCrisis.Models.ViewModels;

namespace HackTheCrisis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        private const int START_PAGE_LIST_COUNT = 5;

        public HomeController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var modelBuilder = new SearchModelBuilder(_context);

            //var viewDataNeeds = modelBuilder.NeedsViewModel();
            //var viewDataOffers = modelBuilder.OffersViewModel();

            var searchResultViewModel = new List<SearchResultViewModel>();

            // Combine both needs and offers
            //searchResultViewModel.AddRange(viewDataNeeds);
            //searchResultViewModel.AddRange(viewDataOffers);

            // Only show a cuple of hits on the start page
            searchResultViewModel = searchResultViewModel.Take(START_PAGE_LIST_COUNT).ToList();

            return View(searchResultViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Legal()
        {
            return View();
        }
        public IActionResult Need()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Need(Need need)
        {
            _context.Needs.Add(need);
            _context.SaveChanges();
            return View("Index");
        }
        public IActionResult Offer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Offer(Offer offer)
        {
            _context.Offers.Add(offer);
            _context.SaveChanges();
            return View("Index");
        }
        public IActionResult RegisterHealtcareUnit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterHealtcareUnit(HealthCareUnit healthCareUnit)
        {
            _context.HealthCareUnits.Add(healthCareUnit);
            _context.SaveChanges();
            return View("Index");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult RegisterHealth()
        {
            return View();
        }
        public IActionResult RegisterIndustrial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterIndustrial(IndustrialPartner industrialPartner)
        {
            _context.IndustrialPartners.Add(industrialPartner);
            _context.SaveChanges();
            return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
