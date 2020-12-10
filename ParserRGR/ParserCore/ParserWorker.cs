using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;

namespace RGRRiverParser.Parser
{
    public class ParserWorker
    {
        private Parser parser;

        private HtmlParser htmlParser;

        private bool isWorking;  // Запущен ли worker в данный момент
        public bool IsWorking { get { return isWorking; } }

        private string baseURL;  // URL страницы, к которому добавляются относительные ссылки

        public event Action<List<Model.River>, int, int> OnNewData;  // Событие "получение новых данных": полученные данные, уже сделано, всего данных
        public event Action<object> OnCompleted;  // Событие "завершение разбора"

        public ParserWorker(string baseURL)
        {
            this.baseURL = baseURL;
            htmlParser = new HtmlParser();
            parser = new Parser();
        }

        /// <summary>
        /// Запускает Worker с заданной страницы.
        /// </summary>
        /// <param name="startURL">Относительный URL начальной страницы</param>
        public void Start(string startURL, int maxPages)
        {
            isWorking = true;
            Worker(startURL, maxPages);
        }

        public void Stop()
        {
            isWorking = false;
        }

        private async void Worker(string startURL, int maxPages)
        {
            int currentPageCount = 0;
            var currentPage = baseURL + startURL;  // Текущая страница
            while (true) {
                if (!isWorking)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var document = await htmlParser.ParseDocumentAsync(await parser.getHTML(currentPage));
                var links = parser.getRiversURLs(document);
                List<Model.River> rivers = new List<Model.River>();
                int linksOnThisPage = links.Count;
                int doneLinksOnThisPage = 0;
                foreach (var url in links)
                {
                    var r = parser.getRiver(await htmlParser.ParseDocumentAsync(await parser.getHTML(baseURL + url)));
                    rivers.Add(r);
                    doneLinksOnThisPage++;
                    if (rivers.Count > 10)
                    {
                        OnNewData?.Invoke(rivers, doneLinksOnThisPage, linksOnThisPage);
                        rivers.Clear();
                    }
                    if (!isWorking)
                    {
                        OnCompleted?.Invoke(this);
                        return;
                    }
                }
                currentPage = parser.getNextPageLink(document);
                if (currentPage == "" || ++currentPageCount >= maxPages)
                {
                    break;
                }
                currentPage = baseURL + currentPage;
            }
            OnCompleted?.Invoke(this);
            isWorking = false;
        }
    }
}
