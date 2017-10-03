using System;
using System.IO;

class Program
{
    static void Main()
    {
        string startDirectory = Console.ReadLine();
        PrintAllFiles(startDirectory);
    }

    static void PrintAllFiles(string startDirectory)
    {
        try
        {
            string[] folders = Directory.GetDirectories(startDirectory);
            foreach (string folder in folders)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(folder);
                PrintAllFiles(folder);
            }

            string[] files = Directory.GetFiles(startDirectory);
            foreach (string file in files)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(file);
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ACCESS DENIED");
        }
    }
}