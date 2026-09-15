using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
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

            int size = matrix.GetLength(0);
            int[] upperTriangle = new int[size * (size - 1) / 2];
            int[] lowerTriangle = new int[size * (size - 1) / 2]; 
            int[] mainDiagonal = new int[size]; 

            int upperIndex = 0;
            int lowerIndex = 0;

            int minElement = matrix[0, 0];
            int maxElement = matrix[0, 0];
            int sum = matrix[0, 0];


            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (col > row)
                    {
                        upperTriangle[upperIndex] = matrix[row, col];
                        upperIndex++;
                    }
                    else if (col < row)
                    {
                        lowerTriangle[lowerIndex] = matrix[row, col];
                        lowerIndex++;
                    }

                    if (row == col)
                    {
                        mainDiagonal[row] = matrix[row, col];
                    }

                    int currentElement = matrix[row, col];

                    if (currentElement < minElement)
                    {
                        minElement = currentElement;
                    }

                    if (currentElement > maxElement)
                    {
                        maxElement = currentElement;
                    }

                    sum += currentElement;
                }
            }

            double upperTriangleAverage = CalculateAverage(upperTriangle);
            double lowerTriangleAverage = CalculateAverage(lowerTriangle);
            double mainDiagonalAverage = CalculateAverage(mainDiagonal);

            Console.WriteLine("Елементи верхнього трикутника:");
            PrintArray(upperTriangle);

            Console.WriteLine("Елементи нижнього трикутника:");
            PrintArray(lowerTriangle);

            Console.WriteLine("Елементи головної діагоналі:");
            PrintArray(mainDiagonal);

            Console.WriteLine("Найменший елемент: " + minElement);
            Console.WriteLine("Найбільший елемент: " + maxElement);
            Console.WriteLine("Середнє арифметичне верхнього трикутника: " + upperTriangleAverage);
            Console.WriteLine("Кількість елементів у верхньому трикутнику: " + upperTriangle.Length);
            Console.WriteLine("Сума елементів у верхньому трикутнику: " + GetSum(upperTriangle));
            Console.WriteLine("Середнє арифметичне нижнього трикутника: " + lowerTriangleAverage);
            Console.WriteLine("Кількість елементів у нижньому трикутнику: " + lowerTriangle.Length);
            Console.WriteLine("Сума елементів у нижньому трикутнику: " + GetSum(lowerTriangle));
            Console.WriteLine("Середнє арифметичне головної діагоналі: " + mainDiagonalAverage);
            Console.WriteLine("Кількість елементів на головній діагоналі: " + mainDiagonal.Length);
            Console.WriteLine("Сума елементів на головній діагоналі: " + GetSum(mainDiagonal));

            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static double CalculateAverage(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return (double)sum / array.Length;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
        
    }
}
