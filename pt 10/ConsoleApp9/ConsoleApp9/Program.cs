using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
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

            Console.Write("Введіть початок діапазону: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введіть кінець діапазону: ");
            int end = int.Parse(Console.ReadLine());

            int sumOfMinElements = 0;

            for (int col = 0; col < matrix.GetLength(1); col += 2)
            {
                int minElement = int.MaxValue;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int currentElement = matrix[row, col];

                    if (currentElement >= start && currentElement <= end)
                    {
                        Console.WriteLine("Елемент на позиції [{0},{1}]: {2}", row, col, currentElement);

                        if (currentElement < minElement)
                        {
                            minElement = currentElement;
                        }
                    }
                }

                sumOfMinElements += minElement;
            }

            Console.WriteLine("Сума мінімальних елементів парних стовпців: " + sumOfMinElements);

            Console.ReadLine();
        }
    }
}
