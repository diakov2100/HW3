using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataStorageAndProcessing.Data;

namespace DataStorageAndProcessing.UI
{
    static class SiteParser
    {
        static List<University> Raiting = new List<University>();
        public static List<University> GetJobLinks(string link)
        {
            Raiting = new List<University>();
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(link);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(page);

            List<List<string>> table = doc.DocumentNode.SelectSingleNode("//table[@class='table table-bordered table-hover']")
                        .Descendants("tr")
                        .Skip(1)
                        .Where(tr => tr.Elements("td").Count() > 1)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                        .ToList();
            foreach (List<string> Univ in table)
            {
                Raiting.Add(new University(Raiting.Count + 1, Univ));
            }
            return (Raiting);
        }
    }
}
