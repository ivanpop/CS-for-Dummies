using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_12c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arr size: ");
            int length = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[length, length];
            arr[length - 1, 0] = 1;
            int counter = 1;
            for (int row = length - 2; row >= 0; row--)
            {
                arr[row, 0] = arr[row + 1, 0] + counter;
                int newRow = row;
                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    arr[newRow + 1, diagonal] = arr[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter++;
            }

            arr[0, length - 1] = length * length;
            int diagonalLength = 2;
            int posX = 1;
            int posY = length - 1;
            int prevX = 0;
            int prevY = length - 1;

            for (int i = 1; i < counter - 1; i++)
            {
                for (int j = 1; j <= diagonalLength; j++)
                {
                    arr[posX, posY] = arr[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = i + 1;
                posY = length - 1;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) Console.Write("{0, 4}", arr[i, j]);
                Console.WriteLine();
            }

        }
    }
}
