using System;

namespace Chapter_13_Solution_6
{
    public class Program
    {
        public void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.", insideTag;
            int startUpCase, endUpCase;

            Console.WriteLine("Original text: \n{0}\n", text);

            do {
                startUpCase = text.IndexOf("<upcase>", 0) + 8;
                endUpCase = text.IndexOf("</upcase>", startUpCase);
                insideTag = text.Substring(startUpCase, endUpCase - startUpCase).ToUpper();
                text = text.Remove(startUpCase, endUpCase - startUpCase);
                text = text.Insert(startUpCase, insideTag);
                text = text.Remove(startUpCase - 8, 8);
                text = text.Remove(endUpCase - 8, 9);
            } while (text.Contains("<upcase>") && text.Contains("</upcase>"));

            Console.WriteLine("Modified text: \n{0}\n", text);
            Console.ReadLine();
        }
    }
}
