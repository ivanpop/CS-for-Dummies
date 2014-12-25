using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a < 0 && b < 0 && c < 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b < 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c < 0) Console.WriteLine("+");
            else if (a >= 0 && b < 0 && c < 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine("-");
        }
    }
}
