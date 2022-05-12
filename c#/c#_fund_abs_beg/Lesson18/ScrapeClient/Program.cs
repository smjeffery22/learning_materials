using ScrapeLibrary;

Scrape myScrape = new Scrape();

string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com ");

Console.WriteLine(value);