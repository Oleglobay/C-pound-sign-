using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5]
        {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25 }
        };

            int diagonalSize = matrix.GetLength(0);
            int[] diagonalElements = new int[diagonalSize];

            for (int i = 0; i < diagonalSize; i++)
            {
                diagonalElements[i] = matrix[i, diagonalSize - i - 1];
            }

            int minElement = diagonalElements[0];
            int maxElement = diagonalElements[0];
            int sum = diagonalElements[0];

            for (int i = 1; i < diagonalSize; i++)
            {
                if (diagonalElements[i] < minElement)
                {
                    minElement = diagonalElements[i];
                }

                if (diagonalElements[i] > maxElement)
                {
                    maxElement = diagonalElements[i];
                }

                sum += diagonalElements[i];
            }

            double average = (double)sum / diagonalSize;

            Console.WriteLine("Найменший елемент бічної діагоналі: " + minElement);
            Console.WriteLine("Найбільший елемент бічної діагоналі: " + maxElement);
            Console.WriteLine("Середнє арифметичне елементів бічної діагоналі: " + average);

            Console.ReadLine();
        }
    }
}
