using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_12d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arr size: ");
            int length = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[length, length];
            int numConcentricSquares = (int)Math.Ceiling((length) / 2.0);
            int sideLen = length;
            int currNum = 0;

            for (int i = 0; i < numConcentricSquares; i++)
            {

                for (int j = 0; j < sideLen; j++) arr[i + j, i] = ++currNum;

                for (int j = 1; j < sideLen - 1; j++) arr[length - 1 - i, i + j] = ++currNum;

                for (int j = sideLen - 1; j > 0; j--) arr[i + j, length - 1 - i] = ++currNum;

                for (int j = sideLen - 1; j > 0; j--) arr[i, i + j] = ++currNum;

                sideLen -= 2;
            }


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) Console.Write("{0, 4}", arr[i, j]);
                Console.WriteLine();
            }
        }
    }
}
