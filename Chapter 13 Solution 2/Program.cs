using System;
using System.Linq;

namespace Chapter_13_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text to reverse: ");
            string input = Console.ReadLine();
            string output = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine("\"{0}\" reversed \"{1}\"", input, output);
            Console.ReadLine();
        }
    }
}