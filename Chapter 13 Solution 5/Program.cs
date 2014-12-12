using System;
using System.Text.RegularExpressions;

namespace Chapter_13_Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out in 5 days.";
            Console.WriteLine(s);
            s = s.ToLower();
            Console.Write("\nEnter substring to search: ");
            string substr = Console.ReadLine();
            substr = substr.ToLower();
            int count = Regex.Matches(s, substr).Count;
            Console.WriteLine("{0} is found {1} times in the text.", substr, count);
            Console.ReadLine();
        }
    }
}