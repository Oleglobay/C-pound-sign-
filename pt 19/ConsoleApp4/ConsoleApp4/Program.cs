using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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

            int max = FindMaxOnMainDiagonal(matrix);
            int min = FindMinOnMainDiagonal(matrix);

            Console.WriteLine($"Максимальний елемент головної діагоналі: {max}");
            Console.WriteLine($"Мінімальний елемент головної діагоналі: {min}");
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

        static int FindMaxOnMainDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int max = matrix[0, 0];

            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                }
            }

            return max;
        }

        static int FindMinOnMainDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int min = matrix[0, 0];

            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] < min)
                {
                    min = matrix[i, i];
                }
            }

            return min;
        }
    }
}
