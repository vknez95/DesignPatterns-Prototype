using System;

namespace WebPageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var scraper = new WebPageScraper("main.html");
            scraper.PrintPageData();

            Console.WriteLine("\n");

            var clonedScraper = scraper.Clone() as WebPageScraper;
            clonedScraper.PrintPageData();
        }
    }
}
