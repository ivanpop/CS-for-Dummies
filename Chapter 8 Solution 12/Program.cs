using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabitToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int thousands = 0, hundreds = 0, tens = 0, ones = 0;
            String result = "";
            Console.Write("Enter Arabic number: ");
            String s = Console.ReadLine();
            int i = Convert.ToInt32(s);

            thousands = i / 1000;
            hundreds = (i / 100) % 10;
            tens = (i / 10) % 10;
            ones = i % 10;

            switch (thousands)
            {
                case 1: result += "M"; break;
                case 2: result += "MM"; break;
                case 3: result += "MMM"; break;                
            }

            switch (hundreds)
            {
                case 1: result += "C"; break;
                case 2: result += "CC"; break;
                case 3: result += "CCC"; break;
                case 4: result += "CD"; break;
                case 5: result += "D"; break;
                case 6: result += "DC"; break;
                case 7: result += "DCC"; break;
                case 8: result += "DCCC"; break;
                case 9: result += "CM"; break;
            }

            switch (tens)
            {
                case 1: result += "X"; break;
                case 2: result += "XX"; break;
                case 3: result += "XXX"; break;
                case 4: result += "XL"; break;
                case 5: result += "L"; break;
                case 6: result += "LX"; break;
                case 7: result += "LXX"; break;
                case 8: result += "LXXX"; break;
                case 9: result += "XC"; break;
            }

            switch (ones)
            {
                case 1: result += "I"; break;
                case 2: result += "II"; break;
                case 3: result += "III"; break;
                case 4: result += "IV"; break;
                case 5: result += "V"; break;
                case 6: result += "VI"; break;
                case 7: result += "VII"; break;
                case 8: result += "VIII"; break;
                case 9: result += "IX"; break;
            }

            Console.WriteLine("Roman number is " + result);
            Console.ReadLine(); 
        }
    }
}
