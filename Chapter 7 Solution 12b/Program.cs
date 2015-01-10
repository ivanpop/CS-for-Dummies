using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_12b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix size: ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            arr[0, 0] = 1;

            for (int i = 1; i < arr.GetLength(0); i++)
                if (i % 2 == 1) arr[0, i] = arr[0, i - 1] + n * 2 - 1;
                else arr[0, i] = arr[0, i - 1] + 1;

            for (int i = 1; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (j % 2 == 1) arr[i, j] = arr[i - 1, j] - 1;
                    else arr[i, j] = arr[i - 1, j] + 1;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) Console.Write("{0, 4}", arr[i, j]);
                Console.WriteLine();
            }
        }
    }
}
