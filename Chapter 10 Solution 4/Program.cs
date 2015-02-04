using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10_Solution_4
{
    class Program
    {
        static string[] wordsArr;

        static void FindSubsets(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}", wordsArr[arr[i]]);
                    if (i != arr.Length - 1) Console.Write(" ");
                }
                Console.Write("), ");
            }
            else
                for (int i = start; i < end; i++)
                {
                    arr[index] = i;
                    FindSubsets(arr, index + 1, i + 1, end);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            wordsArr = new string[length];
            Console.WriteLine();
            for (int i = 0; i < wordsArr.Length; i++)
            {
                Console.Write("Enter {0} word: ", i + 1);
                wordsArr[i] = Console.ReadLine();
            }
            Console.Write("\nEnter K: ");
            int k = Int32.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine();
            FindSubsets(arr, 0, 0, length);
            Console.ReadLine();
        }
    }
}
