using Emm.Filters;
using HtmlAgilityPack;

namespace Emm
{
    public class EmmCrawler
    {
        public IEmmParser<IEmmLogger> Parser { get; set; }
        public string Url { get; set; }

        public EmmCrawler(string url, IEmmParser<IEmmLogger> parser)
        {
            Url = url;
            Parser = parser;
        }

        public void Execute()
        {
            var hw = new HtmlWeb();
            var doc = new HtmlDocument();
            doc = hw.Load(Url);

            var logger = new EmmConsoleLogger();
            Parser.Parse(doc, logger);
        }
    }
}