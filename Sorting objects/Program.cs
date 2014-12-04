using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_objects
{
    class Program
    {
        public class City
        {
            public string name;
            public float gShirina;
            public float gDuljina;
            public float height;
        }

        public static List<City> list = new List<City>();

        public static void showList(List<City> value)
        {
            foreach (var i in value)
            {
                Console.WriteLine("Ime: {0}", i.name);
                Console.WriteLine("G Shirina: {0}", i.gShirina);
                Console.WriteLine("G Duljina: {0}", i.gDuljina);
                Console.WriteLine("Height: {0}\n", i.height);
            }
        }

        static void Main(string[] args)
        {
            list.Add(new City { name = "Sofia", gShirina = 42.42f, gDuljina = 23.2f, height = 590 });
            list.Add(new City { name = "Malko Tarnovo", gShirina = 41.59f, gDuljina = 27.32f, height = 348 });
            list.Add(new City { name = "Polski Trambesh", gShirina = 43.23f, gDuljina = 25.39f, height = 15 });
            list.Add(new City { name = "Belene", gShirina = 43.39f, gDuljina = 28.7f, height = 27 });
            list.Add(new City { name = "Chirpan", gShirina = 42.11f, gDuljina = 25.19f, height = 168 });

            Console.WriteLine("Not sorted");
            showList(list);
            Console.WriteLine("\nSorted by name\n");
            list.Sort(delegate(City x, City y)
            {
                // return x.name.CompareTo(y.name); // compare by city name
                int a = x.name.CompareTo(y.name); // compare by city and gShirina
                if (a == 0)
                    a = x.gShirina.CompareTo(y.gShirina);
                return a;
            });
            showList(list);
            Console.ReadLine();
        }
    }
}
