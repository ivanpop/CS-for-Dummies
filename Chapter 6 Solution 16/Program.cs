using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Solution_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int temp, randomNumber;
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {                
                randomNumber = rnd.Next(0, n);
                temp = arr[i];
                arr[i] = arr[randomNumber];
                arr[randomNumber] = temp;                
            }

            foreach (int i in arr) Console.WriteLine(arr[i]);
        }
    }
}
