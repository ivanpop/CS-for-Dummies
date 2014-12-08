using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Solution_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 999: ");
            short number = Convert.ToInt16(Console.ReadLine());
            byte hundreds = (byte)(number / 100 | 0);
            byte ones, tensAndOnes;
            if (number > 99)
                tensAndOnes = (byte)(number % 100);
            else
                tensAndOnes = (byte)(number * 1);
            ones = (byte)(number % 10);
            switch (hundreds)
            {
                case 1: Console.Write("One hundred "); 
                    break;
                case 2: Console.Write("Two hundred "); 
                    break;
                case 3: Console.Write("Three hundred "); 
                    break;
                case 4: Console.Write("Four hundred ");
                    break;
                case 5: Console.Write("Five hundred ");
                    break;
                case 6: Console.Write("Six hundred ");
                    break;
                case 7: Console.Write("Seven hundred ");
                    break;
                case 8: Console.Write("Eight hundred ");
                    break;
                case 9: Console.Write("Nine hundred ");
                    break;
            }
            if(hundreds >= 1 && tensAndOnes >= 1)
                Console.Write("and ");
            if (tensAndOnes >= 20 && tensAndOnes < 30)
                Console.Write("Twenty");
            else if (tensAndOnes >= 30 && tensAndOnes < 40)
                Console.Write("Thirty");
            else if (tensAndOnes >= 40 && tensAndOnes < 50) 
                Console.Write("Fourty");
            else if (tensAndOnes >= 50 && tensAndOnes < 60)
                Console.Write("Fifty");
            else if (tensAndOnes >= 60 && tensAndOnes < 70)
                Console.Write("Sixty");
            else if (tensAndOnes >= 70 && tensAndOnes < 80) 
                Console.Write("Seventy");
            else if (tensAndOnes >= 80 && tensAndOnes < 90)
                Console.Write("Eighty");
            else if (tensAndOnes >= 90 && tensAndOnes < 100)
                Console.Write("Ninety");
            switch(tensAndOnes)
            {
                case 1: Console.Write("One");
                    break;
                case 2: Console.Write("Two");
                    break;
                case 3: Console.Write("Three");
                    break;
                case 4: Console.Write("Four");
                    break;
                case 5: Console.Write("Five");
                    break;
                case 6: Console.Write("Six");
                    break;
                case 7: Console.Write("Seven");
                    break;
                case 8: Console.Write("Eight");
                    break;
                case 9: Console.Write("Nine");
                    break;
                case 10: Console.Write("Ten");
                    break;
                case 11: Console.Write("Eleven");
                    break;
                case 12: Console.Write("Twelve");
                    break;
                case 13: Console.Write("Thirteen");
                    break;
                case 14: Console.Write("Fourteen");
                    break;
                case 15: Console.Write("Fifteen");
                    break;
                case 16: Console.Write("Sixteen");
                    break;
                case 17: Console.Write("Seventeen");
                    break;
                case 18: Console.Write("Eighteen");
                    break;
                case 19: Console.Write("Nineteen");
                    break;                
            }
            if (tensAndOnes > 20)
            {
                switch (ones)
                {
                    case 1: Console.Write("-one");
                        break;
                    case 2: Console.Write("-two");
                        break;
                    case 3: Console.Write("-three");
                        break;
                    case 4: Console.Write("-four");
                        break;
                    case 5: Console.Write("-five");
                        break;
                    case 6: Console.Write("-six");
                        break;
                    case 7: Console.Write("-seven");
                        break;
                    case 8: Console.Write("-eight");
                        break;
                    case 9: Console.Write("-nine");
                        break;
                }
            }
	        if (number == 0)
                Console.Write("Zero");
            Console.ReadLine();
        }
    }
}