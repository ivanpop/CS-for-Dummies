using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int subset = 0, longestLength = 0;

            Console.Write("Enter arr length: ");
            int length = Int32.Parse(Console.ReadLine());
                        
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int m = (1 << length);
            int[,] subsets = new int[m, length];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < length; j++) subsets[i, j] = i / (m / 2 / (1 << j)) % 2;

            for (int i = 0; i < m; i++)
            {
                int max = -1000, count = 0;

                for (int j = 0; j < length; j++)
                {
                    if (subsets[i, j] > 0)
                    {
                        if (arr[j] >= max)
                        {
                            count++;
                            max = arr[j];
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                }

                if (longestLength < count)
                {
                    longestLength = count;
                    subset = i;
                }
            }

            Console.WriteLine("Result:");
            for (int i = 0; i < length; i++) if (subsets[subset, i] > 0) Console.Write(arr[i] + "; ");
        }
    }
}
