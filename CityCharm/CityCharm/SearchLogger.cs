using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCharm
{
    internal class SearchLogger
    {
        private List<SearchQuery> searchQueries = new List<SearchQuery>();

        public void LogSearchQuery(string Id, string inquiry)
        {
            SearchQuery searchQuery = new SearchQuery
            {
                UserId = Id,
                Query = inquiry,
                Timestamp = DateTime.UtcNow
            };

            searchQueries.Add(searchQuery);
        }

        public List<SearchQuery> GetSearchQueries()
        {
            return searchQueries;
        }
    }

    public class SearchQuery
    {
        public string UserId { get; set; }
        public string Query { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class SearchAnalyzer
    {
        public Dictionary<string, int> GetSearchFrequencies(List<SearchQuery> frequentQueries)
        {
            return frequentQueries
                .GroupBy(q => q.Query)
                .Select(g => new { Query = g.Key, Count = g.Count() })
                .ToDictionary(x => x.Query, x => x.Count);
        }
    }
}
