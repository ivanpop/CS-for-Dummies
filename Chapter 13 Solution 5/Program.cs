using System;
using System.Text.RegularExpressions;

namespace Chapter_13_Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine(str);
            str = str.ToLower();
            Console.Write("\nEnter substring to search: ");
            string substr = Console.ReadLine().ToLower();

            int i = str.IndexOf(substr);

            if (i != -1)
            {
                counter++;

                while (i != -1 && counter >= 1)
                {
                    i = str.IndexOf(substr, i + substr.Length);
                    counter++;
                }

                counter--;
            }

            Console.WriteLine("'{0}' is found {1} times in the text.", substr, counter);
            Console.ReadLine();
        }
    }
}