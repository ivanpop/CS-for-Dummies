using System;
using System.Linq;

namespace Chapter_11_Solution_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter equation: ");
            string equation = Console.ReadLine();
            string[] equationArr = equation.Split(' ');
            string[] actions = new string[equationArr.Length];
            string[] numbers = new string[equationArr.Length];
            bool change = false;
            
            for(int i = 0; i < equationArr.Length; i++)
            {
                if (change) actions[i] = equationArr[i];
                else numbers[i] = equationArr[i];
                change = change ? false : true;                
            }

            numbers = numbers.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            actions = actions.Where(x => !string.IsNullOrEmpty(x)).ToArray();            
            Console.ReadLine();
        }
    }
}