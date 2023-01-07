using System;
using System.Text;

namespace Chapter_13_Solution_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
                if (input[i + 1] != input[i])
                    sb.Append(input[i]);

            sb.Append(input[input.Length - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}