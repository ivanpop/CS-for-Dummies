using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            Console.WriteLine("1.Sum of digits = {0}", a + b + c + d);
            Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);
        }
    }
}
