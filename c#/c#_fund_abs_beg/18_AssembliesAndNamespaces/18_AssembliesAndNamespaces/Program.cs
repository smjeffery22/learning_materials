//using System;
//using System.IO; // namespace for File class
// namespace for WebClient class
//  WebClient class would check if it is under this namespace
using System.Net; 

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!!!!";
            string docPath = "/Users/jp/coding/learning_materials/c#/c#_fund_abs_beg/18_AssembliesAndNamespaces/18_AssembliesAndNamespaces/";


            WebClient client = new WebClient();
            string address = "http://msdn.microsoft.com";
            string reply = client.DownloadString(address);

            Console.WriteLine(reply);
            File.WriteAllText(Path.Combine(docPath, "MS.txt"), reply);
        }
    }
}