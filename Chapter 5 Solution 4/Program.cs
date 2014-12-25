using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Solution_4
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

            if (a < b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
                else if (a >= c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }                
            }
            else if (a == b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", a ,b ,c);
        }
    }
}
