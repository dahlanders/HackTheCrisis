using HackTheCrisis.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTheCrisis.Helpers
{
    public class SearchResult
    {
        public IEnumerable<SearchResultViewModel> Items { get; set; }
        public int ReturnedHits { get; set; }
    }

    public class SearchHelper
    {
        private IEnumerable<SearchResultViewModel> _searchResultViewModel;

        public SearchHelper(IEnumerable<SearchResultViewModel> searchResultViewModel)
        {
            _searchResultViewModel = searchResultViewModel;
        }

        public SearchResult ListAllNeedsAndOffers(int skip = 0, int take = 0, string orderBy = "", string direction = "DESC", string search = "", int filterBy = -1)
        {
            if (_searchResultViewModel == null)
                return new SearchResult();

            //var listData = new List<SearchResultViewModel>();

            //// Populate the view model with needs
            //foreach (var need in _allNeeds)
            //{
            //    listData.Add(
            //        new SearchResultViewModel()
            //        {
            //            Organization = need.Owner.UnitName,
            //            Item = need.Description,
            //            Quantity = need.Quantity,
            //            QuantityUnit = need.QuantityUnit,
            //            Location = need.Owner.City,
            //            DeliveryDate = need.DeliveryDate,
            //            SubmittedDate =  DateTime.Now,//need.SubmittedDate, TODO: Ta tillbaka SubmittedDate
            //            HelpType = HelpType.Needs,
            //            CategoryId = (int)need.EnumNeedType
            //        });
            //}

            //// Populate the view model with offers
            //foreach (var offer in _allOffers)
            //{
            //    listData.Add(
            //        new SearchResultViewModel()
            //        {
            //            Organization = offer.Owner.CompanyName,
            //            Item = offer.Description,
            //            Quantity = 0,
            //            QuantityUnit = "",
            //            Location = offer.Owner.City,
            //            SubmittedDate = DateTime.Now,//offer.SubmittedDate, TODO: Ta tillbaka SubmittedDate
            //            HelpType = HelpType.Offer,
            //            CategoryId = (int)offer.OfferTypes
            //        });
            //}

            //IEnumerable<SearchResultViewModel> result = listData;
            IEnumerable<SearchResultViewModel> result = _searchResultViewModel;

            // Filter
            if (filterBy >= 0)
                result = result.Where(x => x.CategoryId == filterBy);

            // Search term
            if (!string.IsNullOrEmpty(search))
                result = result.Where(x => x.Item.ToLower().Contains(search.ToLower()));

            // Order
            if (direction == "DESC")
                result = result.OrderByDescending(x => x.SubmittedDate);
            else
                result = result.OrderBy(x => x.SubmittedDate);

            int returnedHits = result.Count();

            // Pagniation
            if (skip > 0)
                result = result.Skip(skip);

            // Pagniation
            if (take > 0)
                result = result.Take(take);

            return new SearchResult { Items = result, ReturnedHits = returnedHits };
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
