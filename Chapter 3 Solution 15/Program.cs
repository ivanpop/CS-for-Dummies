using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Solution_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << 2;
            int bitAt3 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 3;
            int bitAt4 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 4;
            int bitAt5 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 23;
            int bitAt24 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 24;
            int bitAt25 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 25;
            int bitAt26 = (v & mask) != 0 ? 1 : 0;

            v = (bitAt3 == 0) ? v = v & (~(1 << 23)) : v = v | (1 << 23);
            v = (bitAt4 == 0) ? v = v & (~(1 << 24)) : v = v | (1 << 24);
            v = (bitAt5 == 0) ? v = v & (~(1 << 25)) : v = v | (1 << 25);
            v = (bitAt24 == 0) ? v = v & (~(1 << 2)) : v = v | (1 << 2);
            v = (bitAt25 == 0) ? v = v & (~(1 << 3)) : v = v | (1 << 3);
            v = (bitAt26 == 0) ? v = v & (~(1 << 4)) : v = v | (1 << 4);

            Console.WriteLine(v);
        }
    }
}
