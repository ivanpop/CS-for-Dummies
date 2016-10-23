using System;

namespace Chapter_13_Solution_12
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("Input HTML: ");
            string text = Console.ReadLine();

            Console.WriteLine("[protocol] = \"{0}\"", text.Substring(0, text.IndexOf("://")));
            Console.WriteLine("[server] = \"{0}\"", text.Substring(text.IndexOf("://") + 3).Split('/'));      
            Console.WriteLine("[resource] = \"{0}\"", text.Substring(text.IndexOf("://") + 3).Substring(text.Substring(text.IndexOf("://") + 3).IndexOf('/')));

            Console.ReadLine();
        }
    }
}
