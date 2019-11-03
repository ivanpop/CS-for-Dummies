using System;

namespace Chapter_13_Solution_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text (20 char max): ");
            string text = Console.ReadLine();

            text = text.PadRight(20, '*');

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}