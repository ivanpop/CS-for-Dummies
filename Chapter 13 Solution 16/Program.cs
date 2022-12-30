using System;

namespace Chapter_13_Solution_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=\"http://softuni.bg\">our site</a> to choose a software engineering training course. Also visit<a href=\"http://softuni.bg" + "/forum\">our forum</a> to discuss the courses.</ p >";
            text = text.Replace("<a href=\"", "[URL=");
            text = text.Replace("\">", "]");
            text = text.Replace("</a>", "[/URL]");

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}