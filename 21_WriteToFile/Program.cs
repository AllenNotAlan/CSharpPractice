using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;


namespace _21_WriteToFile
{
    class Program
    {
        static ScrapingBrowser _browser = new ScrapingBrowser();
        static void Main(string[] args)
        {
            var mainPageLinks = GetMainPageLinks("http://www.practicepython.org/");

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\allen\Desktop\CSharp\Exercises\21_WriteToFile\results.txt"))
            {

                foreach (var elem in mainPageLinks)
                {
                    file.WriteLine(elem);
                }

            }
        }

        //method to grab all links from a page
        static List<string> GetMainPageLinks(string url)
        {
            var homePageLinks = new List<string>();
            var html = GetHtml(url);
            var links = html.CssSelect("a");

            foreach (var link in links)
            {
                if (link.Attributes["href"].Value.Contains(".html"))
                {
                    homePageLinks.Add(link.Attributes["href"].Value);
                }
            }

            return homePageLinks;
        }

        //gets the url of the html page and returns the page
        static HtmlNode GetHtml(string url)
        {
            WebPage webpage = _browser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }
    }
}
