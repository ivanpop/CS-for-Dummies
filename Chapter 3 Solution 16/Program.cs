using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Solution_16
{
    class Program
    {
        private static uint ModifyNumber(uint number, int p, int q, int k)
        {
            int[] pBits = new int[k];
            int[] qBits = new int[k];

            for (int position = p, i = 0; i < pBits.Length; position++, i++)
            {
                pBits[i] = PthBit(number, position);
            }

            for (int position = q, i = 0; i < qBits.Length; position++, i++)
            {
                qBits[i] = PthBit(number, position);
            }

            for (int position = p, i = 0; i < qBits.Length; position++, i++)
            {
                number = ModifiedNumber(number, position, qBits[i]);
            }

            for (int position = q, i = 0; i < pBits.Length; position++, i++)
            {
                number = ModifiedNumber(number, position, pBits[i]);
            }
            return number;
        }

        private static int PthBit(uint number, int position)
        {
            uint pthBit = (number >> position) & 1;
            return (int)pthBit;
        }

        private static uint ModifiedNumber(uint number, int position, int bitValue)
        {
            uint actualP = (uint)bitValue << position;
            number = number & (~((uint)1 << position));
            uint result = number | actualP;
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Enter p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());


            if (p > q)
            {
                int oldValue = p;
                p = q;
                q = oldValue;
            }

            if (p + k >= q)
            {
                k += p - q - 1;
                q += p + k + 1;
            }

            number = ModifyNumber(number, p, q, k);

            Console.WriteLine(number);
        }
    }
}
