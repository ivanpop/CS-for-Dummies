using System;

namespace Chapter_5_Solution_6
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Input A (not 0): ");
            sbyte a = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input B: ");
            sbyte b = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input C: ");
            sbyte c = Convert.ToSByte(Console.ReadLine());

            sbyte d = (sbyte)(b * b - 4 * a * c);
            if (d < 0)
                Console.WriteLine("\nD={0}\nThere are no real roots.", d);
            else if (d == 0)
            {
                sbyte x1 = (sbyte)(-b / 2 * a);
                Console.WriteLine("\nX={0}", x1);
            }
            else
            {
                sbyte x1 = (sbyte)((-b + Math.Sqrt(d)) / (2 * a));
                sbyte x2 = (sbyte)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
            }
            Console.ReadLine();
        }
    }
}