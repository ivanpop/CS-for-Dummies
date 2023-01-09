using System;

namespace Chapter_13_Solution_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            string[] words = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            foreach (var word in words)
                Console.WriteLine(word);
        }
    }
}