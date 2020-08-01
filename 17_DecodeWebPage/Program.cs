using System;
//all packages and/or packages needed for this to work
using System.Collections.Generic;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace _17_DecodeWebPage
{
    class Program
    {
        // a new static ScrapingBrowser variable.
        static ScrapingBrowser _browser = new ScrapingBrowser();
        static void Main(string[] args)
        {
            var mainPageLinks = GetMainPageLinks("http://www.practicepython.org/");
            
            foreach (var elem in mainPageLinks)
            {
                Console.WriteLine(elem);
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
