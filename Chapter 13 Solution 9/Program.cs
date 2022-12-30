using System;

namespace Chapter_13_Solution_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text: ");
            string text = Console.ReadLine();
            Console.Write("Input cipher: ");
            string cipher = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                ushort textChar = text[i];
                ushort cipherChar = cipher[i % cipher.Length];

                Console.Write("\\u{0:x4}", textChar ^ cipherChar);
            }                

            Console.ReadLine();
        }
    }
}