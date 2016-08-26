using System;

namespace Chapter_13_Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "one\two\three";
            string[] sArr = s.Split('\\');
            foreach (string word in sArr) Console.WriteLine(word);            
            Console.ReadLine();
        }
    }
}
