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

            int maxMinInEvenColumns = FindMaxMinInEvenColumns(matrix);

            Console.WriteLine($"Найбільший з мінімальних елементів по парних стовпцях: {maxMinInEvenColumns}");
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

        static int FindMaxMinInEvenColumns(int[,] matrix)
        {
            int maxMinInEvenColumns = int.MinValue;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 0; j < m; j += 2)
            {
                int minInColumn = int.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] < minInColumn)
                    {
                        minInColumn = matrix[i, j];
                    }
                }

                if (minInColumn > maxMinInEvenColumns)
                {
                    maxMinInEvenColumns = minInColumn;
                }
            }

            return maxMinInEvenColumns;
        }
    }
}
