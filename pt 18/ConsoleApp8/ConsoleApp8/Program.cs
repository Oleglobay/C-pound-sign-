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
            int n = 5; // Кількість рядків
            int m = 5; // Кількість стовпців

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

            SwapMinMaxInOddColumns(matrix);

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

        static void SwapMinMaxInOddColumns(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 1; j < m; j += 2)
            {
                int maxInColumn = matrix[0, j];
                int minInColumn = matrix[0, j];
                int maxRowIndex = 0;
                int minRowIndex = 0;

                for (int i = 1; i < n; i++)
                {
                    if (matrix[i, j] > maxInColumn)
                    {
                        maxInColumn = matrix[i, j];
                        maxRowIndex = i;
                    }

                    if (matrix[i, j] < minInColumn)
                    {
                        minInColumn = matrix[i, j];
                        minRowIndex = i;
                    }
                }

                // Міняємо місцями максимальний і мінімальний елементи в поточному стовпці
                int temp = matrix[maxRowIndex, j];
                matrix[maxRowIndex, j] = matrix[minRowIndex, j];
                matrix[minRowIndex, j] = temp;
            }
        }
    }
}
