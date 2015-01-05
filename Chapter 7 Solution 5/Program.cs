using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int sames = 1, bestSames = 1, lastElement = 0;
            int[] arrOfBests = new int[length];

            for (int i = 0; i < arr.Length; i ++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = lastElement - (bestSames - 1); i <= lastElement; i++)
            {
                arrOfBests[i] = arr[i];
            }

            Console.WriteLine("Maximal sequence increase is {0} elements long.", bestSames);
            
            for (int i = 0; i < lastElement; i++)
            {
                Console.WriteLine(arrOfBests[i]);
            }

            Console.ReadLine();
        }
    }
}
