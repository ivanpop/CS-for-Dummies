using System;

namespace Chapter_11_Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');            

            for (int i = 0; i < splitNumbers.Length; i++)
                result += Convert.ToInt32(splitNumbers[i]);

            Console.WriteLine("Result is: {0}", result);
        }
    }
}