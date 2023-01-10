using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Chapter_13_Solution_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "<html><head><title>News</title></head> <body><p><a href=\"http://softuni.bg\">Software University(SoftUni)</a> provides <b>high-quality education</b> forsoftware engineers, profession and job.</p></body></html>";

            Regex regex = new Regex(@"<title>(?'title'.*?)</title>.*<body>(?'body'.*?)</body>");
            Match match = regex.Match(text);

            Console.WriteLine("Title: " + match.Groups["title"].Value);

            StringBuilder sb = new StringBuilder("Body: ");
            bool insideTag = false;

            foreach (char c in match.Groups["body"].Value)
            {
                if (c == '<')
                    insideTag = true;
                else if (c == '>' && insideTag)
                {
                    insideTag = false;
                    continue;
                } 

                if (!insideTag)
                    sb.Append(c);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}