using System;
using System.Text.RegularExpressions;

namespace Chapter_13_Solution_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test @test. This also: @gmail.com.Neither this: a @a.b.";

            Regex regex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9._%+-]+\b");
            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
                Console.WriteLine(match);
        }
    }
}