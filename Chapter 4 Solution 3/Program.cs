using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string compAddr = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string compPhone = Console.ReadLine();
            Console.Write("Enter company fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Enter company website: ");
            string compSite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string compManager = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string managerFName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string managerLName = Console.ReadLine();
            Console.Write("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAddr, compPhone, compFax, compSite, compManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFName, managerLName, managerPhone);
        }
    }
}
