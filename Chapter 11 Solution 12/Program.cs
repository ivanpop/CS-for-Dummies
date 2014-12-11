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
        public static double temp = 0;
        public static byte depth = 0;
        public static byte brakets = 0;

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

            do
            {
                for (int i = 0; i < actions.Length; i++)
                {
                    if (i == 0)
                    {
                        if (actions[i] == "*" || actions[i] == "/")
                        {
                            if (actions[i] == "*") temp = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
                            else temp += Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
                            numbers[0] = temp.ToString();
                            actions[i] = numbers[1] = null;
                            temp = 0;
                            removeNulls();
                        }
                    }
                    else
                    {
                        do
                        {
                            if (actions[i] == "*" || actions[i] == "/")
                            {
                                if (actions[i] == "*") temp = Convert.ToDouble(numbers[i]) * Convert.ToDouble(numbers[i + 1]);
                                else temp += Convert.ToDouble(numbers[i]) / Convert.ToDouble(numbers[i + 1]);
                                numbers[i] = temp.ToString();
                                actions[i] = numbers[i + 1] = null;
                                temp = 0;
                                removeNulls();
                                if (depth > 0) depth--;
                            }
                            foreach (var s in actions)
                            {
                                if (s == "*" || s == "/") depth++;
                            }
                        } while (depth != 0);
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

                Console.WriteLine("Continue {0} to +-", result);
                Console.ReadLine();

                for (int i = 0; i < actions.Length; i++)
                {
                    if (i == 0)
                    {
                        if (actions[i] == "+" || actions[i] == "-")
                        {
                            if (actions[i] == "+") numbers[0] = (Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1])).ToString();
                            else numbers[0] = (Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1])).ToString();                            
                            actions[i] = numbers[1] = null;
                            removeNulls();
                            i--;
                        }                    
                    }
                    else
                    {
                        do
                        {
                            if (actions[i] == "+" || actions[i] == "-")
                            {
                                if (actions[i] == "+") numbers[i] = (Convert.ToDouble(numbers[i]) + Convert.ToDouble(numbers[i + 1])).ToString();
                                else numbers[i] = (Convert.ToDouble(numbers[i]) - Convert.ToDouble(numbers[i + 1])).ToString();
                                actions[i] = numbers[i + 1] = null;
                                removeNulls();
                                if (depth > 0) depth--;
                            }
                            foreach (var s in actions)
                            {
                                if (s == "+" || s == "-") depth++;
                            }
                        } while (depth != 0);
                    }
                }

                for (int i = 0; i < actions.Length; i++)
                {
                    Console.WriteLine("actions {0}",actions[i]);
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("numbers {0}", numbers[i]);
                }                
            } while (numbers.Length > 1);

            Console.WriteLine("Result is {0}", numbers);
            Console.ReadLine();
        }
    }
}