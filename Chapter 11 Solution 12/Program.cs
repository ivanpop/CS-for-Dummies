using System;
using System.Linq;

namespace Chapter_11_Solution_12
{
    class Program
    {
        public static string equation;
        public static string[] equationArr = new string[50];
        public static string[] actions = new string[50];
        public static string[] numbers = new string[50];
        public static bool change = false;
        public static double result = 0;

        public static void removeNulls()
        {
            numbers = numbers.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            actions = actions.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        static void Main(string[] args)
        {            
            Console.WriteLine("Enter equation: ");
            equation = Console.ReadLine();
            equationArr = equation.Split(' ');            

            for(int i = 0; i < equationArr.Length; i++)
            {
                if (change) actions[i] = equationArr[i];
                else numbers[i] = equationArr[i];
                change = change ? false : true;                
            }
            removeNulls();

            for (int i = 0; i < actions.Length; i++)
            {   
                if (i == 0)
                {
                    if (actions[i] == "*")
                    {                        
                        result += Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
                        numbers[0] = result.ToString();
                        actions[i] = numbers[1] = null;
                        removeNulls();
                    }
                    if (actions[i] == "/")
                    {
                        result += Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
                        numbers[0] = result.ToString();
                        actions[i] = numbers[1] = null;
                        removeNulls();
                    }
                }
                else
                {
                    if (actions[i] == "*")
                    {
                        result += Convert.ToDouble(numbers[i]) * Convert.ToDouble(numbers[i + 1]);
                        numbers[i] = result.ToString();
                        actions[i] = numbers[i + 1] = null;
                        removeNulls();
                    }
                    if (actions[i] == "/")
                    {
                        result += Convert.ToDouble(numbers[i]) / Convert.ToDouble(numbers[i + 1]);
                        numbers[i] = result.ToString();
                        actions[i] = numbers[i + 1] = null;
                        removeNulls();
                    }
                }
            }

            for (int i = 0; i < actions.Length; i++)
            {
                Console.WriteLine(actions[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Result = {0}", result);
            Console.ReadLine();
        }
    }
}