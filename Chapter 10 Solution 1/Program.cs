using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10_Solution_1
{
    class Program
    {
        static void Loops(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr) Console.Write("{0} ", element);
                Console.WriteLine();
            }
            else
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Loops(arr, index + 1);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");            
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Loops(arr, 0);
        }
    }
}
