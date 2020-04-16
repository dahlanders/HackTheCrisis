using HackTheCrisis.Data;
using HackTheCrisis.Models;
using HackTheCrisis.Models.ViewModels;
using HackTheCrisis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Helpers
{
    public class SearchModelBuilder
    {
        private readonly SearchRepository _searchRepository;

        public SearchModelBuilder(ApplicationDbContext context)
        {
            _searchRepository = new SearchRepository(context);
        }

        public IEnumerable<SearchResultViewModel> NeedsViewModel()
        {
            var allNeeds = _searchRepository.GetAllNeeds();
            var viewDataNeeds = new List<SearchResultViewModel>();

            // Populate the view model with needs
            foreach (var need in allNeeds)
            {
                viewDataNeeds.Add(
                    new SearchResultViewModel()
                    {
                        Organization = need.Owner.UnitName,
                        Item = need.Description,
                        Quantity = need.Quantity,
                        QuantityUnit = need.QuantityUnit,
                        Location = need.Owner.City,
                        DeliveryDate = need.DeliveryDate,
                        SubmittedDate = DateTime.Now,//need.SubmittedDate, TODO: Ta tillbaka SubmittedDate
                        HelpType = HelpType.Needs,
                        CategoryId = (int)need.EnumNeedType
                    });
            }
            return viewDataNeeds;
        }

        public IEnumerable<SearchResultViewModel> OffersViewModel()
        {
            var allOffers = _searchRepository.GetAllOffers();
            var viewDataOffers = new List<SearchResultViewModel>();

            // Populate the view model with offers
            foreach (var offer in allOffers)
            {
                viewDataOffers.Add(
                    new SearchResultViewModel()
                    {
                        Organization = offer.Owner.CompanyName,
                        Item = offer.Description,
                        Quantity = 0,
                        QuantityUnit = "",
                        Location = offer.Owner.City,
                        SubmittedDate = DateTime.Now,//offer.SubmittedDate, TODO: Ta tillbaka SubmittedDate
                        HelpType = HelpType.Offer,
                        CategoryId = (int)offer.OfferTypes
                    });
            }
            return viewDataOffers;
        }
    }
}
