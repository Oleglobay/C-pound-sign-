using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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

            int sum = SumSecondaryDiagonal(matrix);
            Console.WriteLine($"Сума елементів побічної діагоналі: {sum}");
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

        static int SumSecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, n - 1 - i];
            }

            return sum;
        }
    }
}
