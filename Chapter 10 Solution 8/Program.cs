using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10_Solution_8
{
    class Program
    {
        public static bool isSubsetSum(int[] arr, int n, int sum)
        {
            bool[,] subset = new bool[sum + 1, n + 1];

            for(int i = 0; i <= n; i++)
                subset[0,i] = true;

            for(int i = 1; i <= sum; i++)
                subset[i,0] = false;

            for(int i = 1; i <= sum; i++)
                for(int j = 1; j <= n; j++)
                {
                    subset[i,j] = subset[i, j-1];
                    if(i >= arr[j - 1])
                        subset[i,j] = subset[i,j] || subset[i - arr[j-1], j-1];
                }

            return subset[sum, n];
        }

        static void Main(string[] args)
        {
            Console.Write("Enter arr length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter sum: ");
            int sum = Int32.Parse(Console.ReadLine());

            if (isSubsetSum(arr, arr.Length, sum) == true)
                Console.WriteLine("Found a subset with given sum");
            else
                Console.WriteLine("No subset with given sum");
            Console.ReadLine();
        }
    }
}
