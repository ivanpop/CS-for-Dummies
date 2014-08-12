using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_Solution_11
{
    class Program
    {

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Reverse()
        {
            int numberReverse;
            string stringNumberReverse;
            do
            {
                Console.Clear();
                Console.Write("Vuvedete neotricatelno chislo: ");
                stringNumberReverse = Console.ReadLine();
                numberReverse = int.Parse(stringNumberReverse);
            } while (numberReverse < 0);

            Console.WriteLine("Chisloto oburnato " + ReverseString(stringNumberReverse));
            Console.ReadLine();
        }

        static void Average()
        {
            int numberAverage = 0;
            int entries = -1;
            int temp;
            string numberAverageString;
            bool input;
            Console.Clear();

            do
            {
                Console.Write("Vuvedete chislo ot redicata. Vuvedete bukva za da prikluchite: ");
                numberAverageString = Console.ReadLine();
                input = Int32.TryParse(numberAverageString, out temp);
                numberAverage += temp;
                entries++;
            } while (input);
                       
            Console.WriteLine("Srednoto aritmetichno e {0}.", (float)numberAverage / entries);
            Console.ReadLine();
        }

        static void SolveEquation()
        {
            int a = 0;

            do
            {
                Console.Clear();
                Console.Write("Vuvedete a: ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("Vuvedete b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b/a);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            byte choice;

            do
            {
                Console.Clear();
                Console.WriteLine("##########################################");
                Console.WriteLine("#   M     M  EEEEEEE  N     N  U     U   #");
                Console.WriteLine("#   M M M M  E        N N   N  U     U   #");
                Console.WriteLine("#   M  M  M  EEEEE    N  N  N  U     U   #");
                Console.WriteLine("#   M     M  E        N   N N  U     U   #");
                Console.WriteLine("#   N     N  EEEEEEE  N     N   UUUUU    #");
                Console.WriteLine("##########################################" + System.Environment.NewLine);
                Console.WriteLine("1.Obrushtane posledovatelnostta na chislo.");
                Console.WriteLine("2.Sredno aritmetichno na redica ot chisla.");
                Console.WriteLine("3.Reshavane na uravnenie: a * x + b = 0.");
                Console.WriteLine("4.Izhod.");
                Console.Write("Vuvedete izbor: ");

                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Reverse(); break;
                    case 2: Average(); break;
                    case 3: SolveEquation(); break;
                }

            } while (choice != 4);

            Console.WriteLine(System.Environment.NewLine + "Krai!");
            Console.ReadLine();
        }
    }
}
