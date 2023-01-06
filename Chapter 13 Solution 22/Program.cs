using System;

namespace Chapter_13_Solution_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            char[] arr = new char[65536];

            foreach (char c in input)
                arr[c]++;

            for (int i = 0; i < 65536; i++)
                if (arr[i] > 0)
                    Console.WriteLine($"{(char)i} - {(int)arr[i]}");
        }
    }
}