using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using ImportLokomotivStats.DTO;
using System.Collections.Generic;
using System.Net.Http;

namespace ImportLokomotivStats
{
    internal class Parser
    {
        private readonly HttpClient _httpClient;

        internal const string WikiEndpoint = "https://ru.wikipedia.org/wiki";

        internal Parser()
        {
            _httpClient= new HttpClient();
        }

        internal async List<MatchResult> GetMatchResults(int year)
        {
            var resultEndpoint = GetEndpointWithDate(year);
            var response = await _httpClient.GetAsync(resultEndpoint);
            var htmlString = await response.Content.ReadAsStringAsync();
            var html = new HtmlDocument();
            html.LoadHtml(htmlString);

            var document = html.DocumentNode;
            document.QuerySelectorAll("d");
        }

        private string GetEndpointWithDate(int year)
        {
            return $"{WikiEndpoint}/ФК_«Локомотив»_Москва_в_сезоне_{year}/{year + 1}";
        }
    }
}
