using System;

namespace Chapter_9_Solution_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i > -1; i--)
            {
                Console.Write(s[i]);
            }
            Console.ReadLine();
        }
    }
}