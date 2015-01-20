using System;

namespace Chapter_9_Solution_5
{
    class Program
    {
        static void CompareNumber(int pos, int[] arr)
        {
            if (pos == 0)
            {
                if (arr[0] < arr[1]) Console.WriteLine("{0} is smaller than it's right.", arr[0]);
                else if (arr[0] > arr[1]) Console.WriteLine("{0} is bigger than it's right.", arr[0]);
                else Console.WriteLine("{0} is equal to it's right.", arr[0]);
            }
            else if (pos == arr.Length - 1)
            {
                if (arr[arr.Length - 1] < arr[arr.Length - 2]) Console.WriteLine("{0} is smaller than it's left.", arr[pos]);
                else if (arr[arr.Length - 1] > arr[arr.Length - 2]) Console.WriteLine("{0} is bigger than it's left.", arr[pos]);
                else Console.WriteLine("{0} is equal to it's left.", arr[pos]);
            }
            else
            {
                if (arr[pos] < arr[pos - 1])
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} is smaller than it's neighbours.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} is smaller than it's left and equal to it's right.", arr[pos]);
                    else Console.WriteLine("{0} is smaller than it's left and bigger than it's right.", arr[pos]);
                }
                else if (arr[pos] == arr[pos - 1])
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} is euqal to it's left and smaller than it's right.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} is equal to it's neighbours.", arr[pos]);
                    else Console.WriteLine("{0} is equal to it's left and bigger than it's right.", arr[pos]);
                }
                else
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} is bigger than it's left and smaller than it's right.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} is bigger than it's left and equal to it's right.", arr[pos]);
                    else Console.WriteLine("{0} is bigger than it's neighbours.", arr[pos]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter position in array: ");
            int pos = Int32.Parse(Console.ReadLine());

            CompareNumber(pos, arr);
        }
    }
}
