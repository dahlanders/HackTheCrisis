using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Models.ViewModels
{
    public class SearchListComponentModel
    {
        public IEnumerable<SearchResultViewModel> SearchResult { get; set; }
        public SelectList Filter { get; set; }
    }
}
