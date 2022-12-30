using System;
using System.Collections.Generic;

namespace Chapter_13_Solution_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes\n";

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string[] textParsedByNewline = text.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in textParsedByNewline)
            {
                string[] keywordAndMeaning = line.Split(" - ");
                dictionary.Add(keywordAndMeaning[0], keywordAndMeaning[1]);
            }

            Console.Write("Enter word: ");
            string input = Console.ReadLine();

            foreach (var item in dictionary)
                if (item.Key == input)
                {
                    Console.WriteLine(item.Value);
                    return;
                }

            Console.WriteLine($"Dictionary doesn't contain \"{input}\"");
        }
    }
}