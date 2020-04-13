using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTheCrisis.Data;
using HackTheCrisis.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}