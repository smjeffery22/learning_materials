using System.Text;

void Main()
{
    //string myString = "My \"so-called\" life";
    //string myString = "What if I need a\nnew line?";
    //string myString = "Go to your c:\\ drive";
    //string myString = @"Go to your c:\ drive"; // @ symbol to allow \ to be used as 
    //string myString = String.Format("{0} = {1}", "First", "Second");
    //string myString = string.Format("{0:C}", 123.45); // :C to format the string as a currency
    //string myString = string.Format("{0:N}", 1234567890); // :N to format with comma and decimal point
    //string myString = string.Format("Percentage: {0:P}", .123); // :P to display as percentage
    //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890); // custom format

    //string myString = " That summer we took threes across the board ";

    //myString = myString.Substring(6);
    //myString = myString.Substring(6, 14)
    //myString = myString.ToUpper();
    //myString = myString.Replace(" ", "--");
    //myString = myString.Remove(6, 14);
    //myString = myString.Trim();

    //string myString = "";

    //for (int i = 0; i < 100; i++)
    //{
    //    myString += "--" + i.ToString();
    //}

    StringBuilder myString = new StringBuilder();

    for (int i = 0; i < 100; i++)
    {
        myString.Append("--");
        myString.Append(i);
    }

    Console.WriteLine(myString);
}

Main();