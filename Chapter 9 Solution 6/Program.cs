using System;

namespace Chapter_9_Solution_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberFound = false;
            int[] arr = new int[] { 5, 5, 8, 6, 3, 2, 1, 4, 5, 8, 57, 5, 2, 1, 4, 5, 6, 8, 7, 5, 2 };
            
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if(arr[i] > arr[i - 1] + arr[i + 1])
                {
                    Console.WriteLine(arr[i]);
                    numberFound = true;
                    break;
                }
            }
            if (!numberFound) Console.WriteLine(-1);
            Console.ReadLine();
        }
    }
}