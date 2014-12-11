using System;

namespace Chapter_9_Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 5, 11, 6, 3, 2, 1, 4, 5, 8, 57, 5, 2, 1, 4, 5, 6, 8, 7, 5, 2, 3 };

            foreach(var i in arr) Console.Write("{0} ", i);
            Console.Write("\nEnter index between 1 and 20: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (arr[choice] > arr[choice - 1] + arr[choice +1]) Console.WriteLine("The number is bigger");
            else if (arr[choice] < arr[choice - 1] + arr[choice +1]) Console.WriteLine("The number is smaller");
            else Console.WriteLine("The number is equal");
            Console.ReadLine();
        }
    }
}
