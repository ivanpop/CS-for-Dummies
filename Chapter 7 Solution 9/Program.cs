using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, tempSum;
            
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                tempSum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum) sum = tempSum;
                }
            }

            Console.WriteLine("Result is {0}. ", sum);
        }
    }
}
