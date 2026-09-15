using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 5;

            Random random = new Random();
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(-10, 11);
                }
            }

            Console.WriteLine("Отримана матриця:");
            PrintMatrix(matrix);

            SwapMaxMinInEachRow(matrix);

            Console.WriteLine("Матриця після заміни:");
            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void SwapMaxMinInEachRow(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                int max = matrix[i, 0];
                int min = matrix[i, 0];
                int maxIndex = 0;
                int minIndex = 0;

                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxIndex = j;
                    }

                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndex = j;
                    }
                }

                // Міняємо місцями максимальний і мінімальний елементи в рядку
                int temp = matrix[i, maxIndex];
                matrix[i, maxIndex] = matrix[i, minIndex];
                matrix[i, minIndex] = temp;
            }
        }
    }
}
