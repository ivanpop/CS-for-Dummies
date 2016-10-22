using System;

namespace Chapter_13_Solution_8
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("Input text: ");
            string text = Console.ReadLine();
            foreach (char c in text) Console.Write("\\u{0:x4}", ((int)c));
            Console.ReadLine();
        }
    }
}
