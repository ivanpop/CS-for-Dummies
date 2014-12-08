using System;

namespace Chapter_5_Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte points;
            Console.Write("Enter points between 1 and 9: ");
            points = Convert.ToByte(Console.ReadLine());
            if (points >= 1 && points <= 3)
                Console.WriteLine("Points multiplied by 10: {0}", points * 10);
            else if (points >= 4 && points <= 6)
                Console.WriteLine("Points multiplied by 100: {0}", points * 100);
            else if (points >= 7 && points <= 9)
                Console.WriteLine("Points multiplied by 1000: {0}", points * 1000);
            else
                Console.WriteLine("Wrong Input!");
            Console.ReadLine();
        }
    }
}