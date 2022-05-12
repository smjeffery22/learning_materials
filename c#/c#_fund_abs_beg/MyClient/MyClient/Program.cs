// MyCodeLibrary.dll added to bin => Debug folder

using MyCodeLibrary;

Scrape myScrape = new Scrape();

string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com ");

Console.WriteLine(value);