try
{
    string content = File.ReadAllText("/Users/jp/coding/learning_materials/c#/c#_fund_abs_beg/HandlingExceptions/Exampl.rtf");

    Console.WriteLine(content);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("There was a problem!");
    Console.WriteLine("Make sure the name of the file is named correctly: Example.rtf");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("There was a problem!");
    Console.WriteLine("Make sure the directory exists");
}
catch (Exception ex)
{
    Console.WriteLine("There was a problem!");
    Console.WriteLine(ex.Message);
}
finally
{
    // code to finalize
    // setting objects to null
    // closing database connections
    Console.WriteLine("Closing application now...");
}