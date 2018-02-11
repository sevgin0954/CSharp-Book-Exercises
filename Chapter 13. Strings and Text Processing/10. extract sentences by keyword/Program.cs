using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] sentences = Console.ReadLine()
            .Split(". ", StringSplitOptions.RemoveEmptyEntries);
        string searchedWord = Console.ReadLine();

        string regexString = $"[^a-zA-Z]+{searchedWord}[^a-zA-Z]+";
        Regex regex = new Regex(regexString);

        string filteredSentences = "";

        foreach (string sentence in sentences)
        {
            if (regex.IsMatch(sentence))
            {
                filteredSentences += sentence + Environment.NewLine;
            }
        }

        Console.Write(filteredSentences);
    }
}