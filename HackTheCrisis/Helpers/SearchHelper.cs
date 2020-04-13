using HackTheCrisis.Data;
using HackTheCrisis.Models;
using HackTheCrisis.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Helpers
{
    public class SearchHelper
    {
        private readonly ApplicationDbContext _context;

        public SearchHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> NeedsAndOffersCount()
        {
            var repository = new SearchRepository(_context);

            var needs = await Task.FromResult(repository.GetAllNeeds());
            var offers = await Task.FromResult(repository.GetAllOffers());

            return needs.Count() + offers.Count();
        }

        public async Task<IEnumerable<SearchResultViewModel>> ListAllNeedsAndOffers(int skip = 0, int take = 0, string orderBy = "", string direction = "DESC", string search = "")
        {
            var listData = new List<SearchResultViewModel>();
            var repository = new SearchRepository(_context);

            // Populate the view model with needs
            var needs = await Task.FromResult(repository.GetAllNeeds());
            foreach (var need in needs)
            {
                listData.Add(
                    new SearchResultViewModel()
                    {
                        Organization = need.Owner.UnitName,
                        Item = need.Description,
                        Quantity = need.Quantity,
                        QuantityUnit = need.QuantityUnit,
                        Location = need.Owner.City,
                        DeliveryDate = need.DeliveryDate,
                        SubmittedDate =  DateTime.Now,//need.SubmittedDate, TODO: Ta tillbaka SubmittedDate
                        HelpType = HelpType.Needs
                    });
            }

            // Populate the view model with offers
            var offers = await Task.FromResult(repository.GetAllOffers());
            foreach (var offer in offers)
            {
                listData.Add(
                    new SearchResultViewModel()
                    {
                        Organization = offer.Owner.CompanyName,
                        Item = offer.Description,
                        Quantity = 0,
                        QuantityUnit = "",
                        Location = offer.Owner.City,
                        SubmittedDate = DateTime.Now,//offer.SubmittedDate, TODO: Ta tillbaka SubmittedDate
                        HelpType = HelpType.Offer
                    });
            }

            IEnumerable<SearchResultViewModel> result;

            if(direction == "DESC")
                result = listData.OrderByDescending(x => x.SubmittedDate);
            else
                result = listData.OrderBy(x => x.SubmittedDate);

            if (skip > 0)
                result = result.Skip(skip);

            if(take > 0)
                result = result.Take(take);

            return result;
        }
    }


    //var connectionString = _configuration.GetConnectionString("DefaultConnection");

    ///*** Create an index and define a text analyzer ***/
    //// Ensures index backwards compatibility
    //var appLuceneVersion = Lucene.Net.Util.LuceneVersion.LUCENE_48;

    //CloudStorageAccount cloudAccount = CloudStorageAccount.Parse(connectionString);
    //var cacheDirectory = new RAMDirectory();
    //AzureDirectory azureDirectory = new AzureDirectory(cloudAccount, "MyCloudIndex", cacheDirectory);

    ////create an analyzer to process the text
    //var analyzer = new StandardAnalyzer(appLuceneVersion);

    ////create an index writer
    //var indexConfig = new IndexWriterConfig(appLuceneVersion, analyzer);
    //var writer = new IndexWriter(azureDirectory, indexConfig);

    ///*** Add to the index ***/
    //var source = new
    //{
    //    Name = "Kermit the Frog",
    //    FavoritePhrase = "The quick brown fox jumps over the lazy dog"
    //};

    //Document doc = new Document
    //{
    //    // StringField indexes but doesn't tokenize
    //    new StringField("name", source.Name, Field.Store.YES),
    //    new TextField("favoritePhrase", source.FavoritePhrase, Field.Store.YES)
    //};

    //writer.AddDocument(doc);
    //writer.Flush(triggerMerge: false, applyAllDeletes: false);

    ///*** Construct a query ***/
    //// search with a phrase
    //var phrase = new MultiPhraseQuery();
    //phrase.Add(new Term("favoritePhrase", "brown"));
    //phrase.Add(new Term("favoritePhrase", "fox"));

    ///*** Fetch the results ***/
    //// re-use the writer to get real-time updates
    //var searcher = new IndexSearcher(writer.GetReader(applyAllDeletes: true));
    //var hits = searcher.Search(phrase, 20 /* top 20 */).ScoreDocs;
    //foreach (var hit in hits)
    //{
    //    var foundDoc = searcher.Doc(hit.Doc);
    //    Console.WriteLine(foundDoc);
    //    //hit.Score.Dump("Score");
    //    //foundDoc.Get("name").Dump("Name");
    //    //foundDoc.Get("favoritePhrase").Dump("Favorite Phrase");
    //}

    //writer.Dispose();
    //azureDirectory.Dispose();
}
