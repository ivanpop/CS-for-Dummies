using System;

namespace Chapter_13_Solution_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "entertaining anna Anna civic kayak level madam mom noon racecar radar redder refer repaper rotator rotor sagas solos stats tenet wow recognise existence high-pitched lowly abiding silver skinny instruct promise crow tacit";
            string[] arr = text.Split();

            foreach (var word in arr)
            {
                bool isPolindrom = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPolindrom = false;
                        break;
                    }
                }

                if (isPolindrom)
                    Console.WriteLine(word);
            }
        }
    }
}