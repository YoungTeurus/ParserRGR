using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGRRiverParser.Model;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net;
using AngleSharp.Html.Dom;

namespace RGRRiverParser.Parser
{
    public class Parser
    {
        private HttpClient httpClient;

        public Parser()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> getHTML(string url)
        {
            var response = await httpClient.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }

        /// <summary>
        /// Возвращает относительную ссылку на следующую страницу каталога рек.
        /// </summary>
        /// <param name="document">HTML-страница с ссылками</param>
        public string getNextPageLink(IHtmlDocument document)
        {
            return document.QuerySelectorAll("a").Where(value => value.TextContent == "Следующая страница").First()?.GetAttribute("href");
        }

        /// <summary>
        /// Возвращает List, содержащий ссылки на все страницы с реками.
        /// </summary>
        /// <param name="document">HTML-страница с ссылками</param>
        /// <returns>Список строк, являющихся относительными ссылками на страницы с реками.</returns>
        public List<string> getRiversURLs(IHtmlDocument document)
        {
            List<string> returnList = new List<string>();
            foreach (var item in document.QuerySelectorAll("div.mw-category a"))
            {
                returnList.Add(item.GetAttribute("href"));
            }
            return returnList;
        }

        /// <summary>
        /// Возвращает реку, распарсивая страницу с нею.
        /// </summary>
        /// <param name="document">HTML страница с информацией о реке</param>
        /// <returns>Объект River с заполненными полями.</returns>
        public River getRiver(IHtmlDocument document)
        {
            River returnRiver = new River();

            Regex rlength = new Regex(@"(\d+)");

            returnRiver.name = document.QuerySelector("table.infobox tbody tr th.infobox-above").TextContent;
            foreach (var item in document.QuerySelectorAll("table.infobox tbody tr"))
            {
                var text = item.QuerySelector("th")?.TextContent?.Split('.')[0]?.Split('\n')[0]?.Trim();

                if (text != null && text == "Длина")
                {
                    returnRiver.length = double.Parse(rlength.Match(item.QuerySelector("td").TextContent.Trim()).Groups[1].Value);
                }
                else if(text != null && text == "Исток"){
                    returnRiver.source = item.QuerySelector("td").TextContent.Trim();
                }
                else if (text != null && text == "Устье")
                {
                    returnRiver.mouth = item.QuerySelector("td").TextContent.Trim();
                }
            }

            return returnRiver;
        }
    }
}
