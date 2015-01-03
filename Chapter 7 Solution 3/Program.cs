using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrayEqual = true;
            char[] arrA = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arrB = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (arrA.Length > arrB.Length) Console.WriteLine("Second array is lexicographicaly first.");
            else if (arrA.Length < arrB.Length) Console.WriteLine("First array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] < arrB[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                    if (arrA[i] > arrB[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual) Console.WriteLine("Arrays are lexicographicaly equal.");
            }
        }
    }
}
