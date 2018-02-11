using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Regex regex = new Regex(@"<upcase>(.*?)</upcase>");
        input = regex.Replace(input, m => m.Groups[1].ToString().ToUpper());

        Console.WriteLine(input);
    }
}