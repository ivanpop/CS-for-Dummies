using System;
using System.Text;

namespace Chapter_13_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text to reverse: ");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            input = sb.ToString();

            Console.WriteLine("Reversed: \"{0}\"", input);
            Console.ReadLine();
        }
    }
}