using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToArabic
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;            
            Console.Write("Enter Roman number: ");
            String s = Console.ReadLine();
            string[] chars = s.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == "m" || chars[i] == "M") result += 1000;
                if (chars[i] == "d" || chars[i] == "D") result += 500;
                if (chars[i] == "c" || chars[i] == "C")
                {
                    result += 100;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "d" || chars[i + 1] == "D") result -= 200;
                        if (chars[i + 1] == "m" || chars[i + 1] == "M") result -= 200;
                    }
                }
                if (chars[i] == "l" || chars[i] == "L") result += 50;
                if (chars[i] == "x" || chars[i] == "X")
                {
                    result += 10;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "l" || chars[i + 1] == "L") result -= 20;
                        if (chars[i + 1] == "c" || chars[i + 1] == "C") result -= 20;
                    }
                }
                if (chars[i] == "v" || chars[i] == "V") result += 5;
                if (chars[i] == "i" || chars[i] == "I")
                {
                    result++;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "v" || chars[i + 1] == "V") result -= 2;
                        if (chars[i + 1] == "x" || chars[i + 1] == "X") result -= 2;
                    }
                }
            }

            Console.WriteLine("Arabic number is " + result);
        }
    }
}
