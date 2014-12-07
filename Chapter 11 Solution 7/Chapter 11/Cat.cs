using System;

namespace Chapter_11_Solution_7.Folder
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void sayMiau()
        {
            Console.WriteLine("{0}: Miauu", name);   
        }
    }
}
