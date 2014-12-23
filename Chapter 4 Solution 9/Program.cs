using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, x1, x2;
            Console.Write("Enter A (A != 0): ");
            double a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            double c = Int32.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0) Console.WriteLine("D={0}, There are no real roots.", d);
            else if (d == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("X={0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("X1={0}, X2={1}", x1, x2);
            }
        }
    }
}
