using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; // Розмір матриці nxn

            Random random = new Random();
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-10, 11);
                }
            }

            Console.WriteLine("Отримана матриця:");
            PrintMatrix(matrix);

            int max = FindMaxOnSecondaryDiagonal(matrix);
            int min = FindMinOnSecondaryDiagonal(matrix);
            double average = (max + min) / 2.0;

            Console.WriteLine($"Максимальний елемент побічної діагоналі: {max}");
            Console.WriteLine($"Мінімальний елемент побічної діагоналі: {min}");
            Console.WriteLine($"Середнє арифметичне максимального та мінімального: {average}");
        }

        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int FindMaxOnSecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int max = matrix[0, n - 1];

            for (int i = 1; i < n; i++)
            {
                if (matrix[i, n - 1 - i] > max)
                {
                    max = matrix[i, n - 1 - i];
                }
            }

            return max;
        }

        static int FindMinOnSecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int min = matrix[0, n - 1];

            for (int i = 1; i < n; i++)
            {
                if (matrix[i, n - 1 - i] < min)
                {
                    min = matrix[i, n - 1 - i];
                }
            }

            return min;
        }
    }
}
