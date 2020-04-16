using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models.ViewModels
{
    public class SearchPageViewModel
    {
        public SearchListComponentModel NeedsTab { get; set; }
        public SearchListComponentModel OffersTab { get; set; }
    }
}
