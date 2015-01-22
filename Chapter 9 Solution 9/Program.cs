using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_Solution_9
{
    class Program
    {
        public static int GetMax(int[] array, int start, int end)
        {
            int maxNum = array[start];

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] > maxNum) maxNum = array[i];
            }

            return maxNum;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter start index: ");
            int startIndex = Int32.Parse(Console.ReadLine());

            Console.Write("Enter end index: ");
            int endIndex = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Biggest number in interval {0}-{1} is {2}.", startIndex, endIndex, GetMax(arr, startIndex, endIndex));
        }
    }
}
