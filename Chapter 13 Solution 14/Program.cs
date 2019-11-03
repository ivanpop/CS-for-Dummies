
using System;

namespace Chapter_13_Solution_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string dictionary = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes\n";
            string[] tempDictionary = new string[10];

            tempDictionary = dictionary.Split(new string[] { "\n" }, StringSplitOptions.None);

            Console.Write("Enter word: ");
            string input = Console.ReadLine() + " - ";

            foreach (string str in tempDictionary)
            {
                if (str.Contains(input)) Console.WriteLine(str.Substring(input.Length));
            }
            Console.ReadLine();
        }
    }
}