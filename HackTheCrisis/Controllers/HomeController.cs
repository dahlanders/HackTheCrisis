using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackTheCrisis.Models;
using HackTheCrisis.Data;
using Microsoft.EntityFrameworkCore;
using Lucene.Net.Store.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Extensions.Configuration;
using Lucene.Net.Index;
using Lucene.Net.Store;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Search;
using HackTheCrisis.Helpers;

namespace HackTheCrisis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public HomeController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            //var needs = _context.Needs.ToList();

            //var searchHelper = new SearchHelper(_context);
            //var demands = searchHelper.GetDemands(5);

            //var searchResultViewModel = new List<SearchResultViewModel>();

            //// Populate the search view model
            //foreach (var demand in demands)
            //{
            //    searchResultViewModel.Add(
            //        new SearchResultViewModel()
            //        {
            //            Organization = demand.HealthCareUnit.UnitName,
            //            Item = demand.Item,
            //            Quantity = demand.Quantity,
            //            QuantityUnit = "st",
            //            Location = "Plats saknas",
            //            DeliveryDate = demand.WhenDoINeedIt,
            //            CreatedDate = demand.CreatedDate,
            //            HelpType = HelpType.Needs
            //        });
            //}

            return View(/*searchResultViewModel*/);
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
        public IActionResult HealthCareNeed​()
        {
            return View("SHCN");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
