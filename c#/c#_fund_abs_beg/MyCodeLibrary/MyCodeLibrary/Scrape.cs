using System.Net;

// creating custom namespace called MyCodeLibrary
//  Release => Build
//  can be added into Console Application
//  right click Dependencies => Add Project Reference
//   navigate to this project folder => bin => Release => MyCodeLibrary.dll
namespace MyCodeLibrary;
public class Scrape
{
    public string ScrapeWebpage(string url)
    {
        return GetWebpage(url);
    }

    public string ScrapeWebpage(string url, string filepath)
    {     
        string reply = GetWebpage(url);

        File.WriteAllText(Path.Combine(filepath, "filepath.txt"), reply);

        return reply;
    }

    private string GetWebpage(string url)
    {
        WebClient client = new WebClient();

        return client.DownloadString(url);
    }
}

