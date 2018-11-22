using HtmlAgilityPack;
using System.Collections.Generic;

namespace Emm.Classes
{
    public class EmmBaseLinkParser : IEmmParser<IEmmLogger>
    {
        public virtual string[] Parse(HtmlDocument document, IEmmLogger log)
        {
            var anchors = new List<string>();
            foreach (HtmlNode link in document.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                anchors.Add(hrefValue);

                log.Log(hrefValue);
            }

            log.Log("Links Count: " + anchors.Count);

            return anchors.ToArray();
        }
    }

}
