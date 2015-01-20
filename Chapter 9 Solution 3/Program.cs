using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_Solution_3
{
    class Program
    {
        static void GetName(string number)
        {
            switch (number[number.Length - 1])
            {
                case '1': Console.WriteLine("One"); break;
                case '2': Console.WriteLine("Two"); break;
                case '3': Console.WriteLine("Three"); break;
                case '4': Console.WriteLine("Four"); break;
                case '5': Console.WriteLine("Five"); break;
                case '6': Console.WriteLine("Six"); break;
                case '7': Console.WriteLine("Seven"); break;
                case '8': Console.WriteLine("Eight"); break;
                case '9': Console.WriteLine("Nine"); break;
                case '0': Console.WriteLine("Zero"); break;
                default: Console.WriteLine("Wrong input."); break;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            GetName(number);
        }
    }
}
