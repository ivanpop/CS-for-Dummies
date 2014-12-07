using System;
using Chapter_11_Solution_7.Folder;

namespace Chapter_11_Solution_7.Chapter11.Examples
{
    class Caller
    {
        static void Main(string[] args)
        {
            String name = "Cat";
            for(int i = 0; i < 10; i++)
            {
                Cat cat = new Cat(name + Sequence.NextValue(), "Black");
                cat.sayMiau();
            }
            Console.ReadLine();
        }
    }
}
