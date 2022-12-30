using System;
using System.Globalization;

namespace Chapter_13_Solution_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            date = date.AddHours(6).AddMinutes(30);
            Console.WriteLine(date.ToString());
        }
    }
}