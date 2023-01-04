using System;
using System.Text.RegularExpressions;

namespace Chapter_13_Solution_20
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In\r\n5/1999 I graduated my high school. The law says (see section\r\n7.3.12) that we are allowed to do this (section 7.4.2.9).\r\n";

            Regex regex = new Regex(@"[0-9]{1,2}[.][0-9]{1,2}[.][0-9]{4}");
            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
                Console.WriteLine(match);
        }
    }
}