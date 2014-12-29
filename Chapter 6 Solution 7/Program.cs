using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Solution_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: (1<K<N) ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            int k = Int32.Parse(Console.ReadLine());
            int nMinusK = n - k;

            for (int i = n - 1; i > 0; i--) n *= i;
            for (int i = k - 1; i > 0; i--) k *= i;
            for (int i = nMinusK - 1; i > 0; i--) nMinusK *= i;

            Console.WriteLine("Result is {0}", n * k / nMinusK);
        }
    }
}
