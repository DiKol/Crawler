using HtmlAgilityPack;
using System.Collections.Generic;

namespace Emm.Classes
{
    public class EmmImageParser : EmmBaseLinkParser
    {
        public override string[] Parse(HtmlDocument document, IEmmLogger log)
        {
            var images = new List<string>();
            foreach (HtmlNode link in document.DocumentNode.SelectNodes("//img[@src]"))
            {
                string hrefValue = link.GetAttributeValue("src", string.Empty);
                images.Add(hrefValue);

                log.Log(hrefValue);
            }

            log.Log("Images Count: " + images.Count);

            var anshors = base.Parse(document, log);

            images.AddRange(anshors);

            return images.ToArray();
        }
    }

}
