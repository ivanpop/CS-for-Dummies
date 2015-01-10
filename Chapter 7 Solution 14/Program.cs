using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempSeq = 1, seq = 1;
            string element = "e";

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            int m = Int32.Parse(Console.ReadLine());

            string[,] arr = new string[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Arr [{0}][{1}] = ", i, j);
                    arr[i, j] = Console.ReadLine();
                }


            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1) - 1; cols++)
                {
                    if (arr[rows, cols] == arr[rows, cols + 1]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int cols = 0; cols < arr.GetLength(1); cols++)
            {
                for (int rows = 0; rows < arr.GetLength(0) - 1; rows++)
                {
                    if (arr[rows, cols] == arr[rows + 1, cols]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols < arr.GetLength(1) - 1; rows++, cols++)
                    {
                        if (arr[rows, cols] == arr[rows + 1, cols + 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (arr[rows, cols] == arr[rows + 1, cols - 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i = 0; i < seq; i++) Console.Write("{0}, ", element);
        }
    }
}