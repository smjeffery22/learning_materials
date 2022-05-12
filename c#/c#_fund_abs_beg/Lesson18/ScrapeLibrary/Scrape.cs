﻿using System.Net;

namespace ScrapeLibrary;
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
        string content = client.DownloadString(url); ;
        content += "THAT'S ALL!!!";
        
        return content;
    }
}