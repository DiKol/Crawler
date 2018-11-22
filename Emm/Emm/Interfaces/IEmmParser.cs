using HtmlAgilityPack;

namespace Emm
{
    public interface IEmmParser<U> where U : IEmmLogger
    {
        string[] Parse(HtmlDocument document, U logger);
    }
}
