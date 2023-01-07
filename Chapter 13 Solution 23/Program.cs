using System;
using System.Collections.Generic;

namespace Chapter_13_Solution_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            
            string[] textArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            foreach (var word in textArray)
            {
                if (!dict.ContainsKey(word))
                    dict.Add(word, 0);

                dict[word]++;
            }

            foreach (var word in dict)
                Console.WriteLine($"{word.Key} - {word.Value}");
        }
    }
}