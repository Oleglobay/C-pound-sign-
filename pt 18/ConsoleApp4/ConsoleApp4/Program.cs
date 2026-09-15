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

            int minMaxInOddColumns = FindMinMaxInOddColumns(matrix);

            Console.WriteLine($"Найменший з максимальних елементів по непарних стовпцях: {minMaxInOddColumns}");
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

        static int FindMinMaxInOddColumns(int[,] matrix)
        {
            int minMaxInOddColumns = int.MaxValue;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 1; j < m; j += 2)
            {
                int maxInColumn = int.MinValue;

                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] > maxInColumn)
                    {
                        maxInColumn = matrix[i, j];
                    }
                }

                if (maxInColumn < minMaxInOddColumns)
                {
                    minMaxInOddColumns = maxInColumn;
                }
            }

            return minMaxInOddColumns;
        }
    }
}
