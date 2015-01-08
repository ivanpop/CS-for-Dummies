using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_12a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            int x = Int32.Parse(Console.ReadLine());

            int a = 0;

            for (int i = 1; i <= y; i++)
            {
                Console.Write("{0} ", i);

                a += i;

                for (int j = 1; j < x; j++)
                {
                    a += y;
                    Console.Write("{0} ", a);                    
                }

                a = 0;
                Console.WriteLine();
            }
        }
    }
}
