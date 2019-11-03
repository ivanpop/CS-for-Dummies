
using System;

namespace Chapter_13_Solution_13
{
    public class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string text = "C# is not C++ and PHP is not Delphi";

            text = Reverse(text);

            string[] textArr = text.Split(' ');

            text = "";

            foreach (string s in textArr) text += Reverse(s) + ' ';

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}