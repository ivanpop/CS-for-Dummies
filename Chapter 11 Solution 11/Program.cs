using System;

namespace Chapter_11_Solution_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] firstNames = new string[] { "Diana", "Petia", "Stela", "Elena", "Katia" };
            string[] secondNames = new string[] { "Ivanova", "Petrova", "Kirova", "Popova" };
            string[] cities = new string[] { "Sofia", "Plovdiv", "Varna", "Ruse", "Dolno konare" };
            string[] reviews1 = new string[] { "This product is excelent.", "This is a great product.", "I use this product all the time.", "This is the best product of this category." };
            string[] reviews2 = new string[] { "Now I feel better.", "I changed.", "It was a miracle.", "I can't believe it. Now I feel better.", "Try it yourself. I'm very greatful." };

            Console.WriteLine("{0} {1}\n-- {2} {3}, {4}.", reviews1[rnd.Next(4)], reviews2[rnd.Next(5)], firstNames[rnd.Next(5)], secondNames[rnd.Next(4)], cities[rnd.Next(5)]);
        }
    }
}
