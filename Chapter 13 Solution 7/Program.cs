using System;

namespace Chapter_13_Solution_7
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("Input text (20 char max): ");
            string text = Console.ReadLine();

            while (text.Length > 20)
            {
                Console.Write("Input 20 char max!: ");
                text = Console.ReadLine();
            }

            while (text.Length < 20) text += "*";

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
