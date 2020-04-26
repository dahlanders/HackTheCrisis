using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTheCrisis.Data;
using HackTheCrisis.Helpers;
using HackTheCrisis.Models;
using HackTheCrisis.Models.ViewModels;
using HackTheCrisis.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static HackTheCrisis.Models.Need;
using static HackTheCrisis.Models.Offer;

namespace HackTheCrisis.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Search
        public ActionResult Index()
        {
            var modelBuilder = new SearchModelBuilder(_context);

            //var needsViewData = modelBuilder.NeedsViewModel();
            //var offersViewData = modelBuilder.OffersViewModel();


            var needEnums = Enum.GetValues(typeof(NeedType)).Cast<NeedType>();
            var offerEnums = Enum.GetValues(typeof(OfferType)).Cast<OfferType>();

            var needsFilter = new List<SelectListItem>();
            var offersFilter = new List<SelectListItem>();

            foreach (var item in needEnums)
                needsFilter.Add(new SelectListItem { Selected = false, Text = item.ToString(), Value = ((int)item).ToString() });
            
            foreach (var item in offerEnums)
                offersFilter.Add(new SelectListItem { Selected = false, Text = item.ToString(), Value = ((int)item).ToString() });

            var model = new SearchPageViewModel
            {
                NeedsTab = new SearchListComponentModel
                {
                    //SearchResult = needsViewData,
                    FilterOptions = needsFilter
                },
                OffersTab = new SearchListComponentModel
                {
                    //SearchResult = offersViewData,
                    FilterOptions = offersFilter
                }
            };

            return View(model);
        }
    }
}