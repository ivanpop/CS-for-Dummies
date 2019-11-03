
using System;

namespace Chapter_13_Solution_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.", forbiddenWords = "C#,CLR,Microsoft";
            string[] forbiddenWordsArr = forbiddenWords.Split(',');
            string[] censoredForbiddenWordsArr = new string[forbiddenWordsArr.Length];

            for (int i = 0; i < forbiddenWordsArr.Length; i++)
                censoredForbiddenWordsArr[i] = new string('*', forbiddenWordsArr[i].Length);

            for (int i = 0; i < forbiddenWordsArr.Length; i++)
                text = text.Replace(forbiddenWordsArr[i], censoredForbiddenWordsArr[i]);

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}