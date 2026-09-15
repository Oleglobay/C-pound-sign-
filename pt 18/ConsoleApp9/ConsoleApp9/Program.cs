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

            SwapMinInEvenColumnsWithMaxInOddColumns(matrix);

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

        static void SwapMinInEvenColumnsWithMaxInOddColumns(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 0; j < m - 1; j += 2)
            {
                int maxInOddColumn = matrix[0, j + 1];
                int minInEvenColumn = matrix[0, j];
                int maxRowIndex = 0;
                int minRowIndex = 0;

                for (int i = 1; i < n; i++)
                {
                    if (matrix[i, j + 1] > maxInOddColumn)
                    {
                        maxInOddColumn = matrix[i, j + 1];
                        maxRowIndex = i;
                    }

                    if (matrix[i, j] < minInEvenColumn)
                    {
                        minInEvenColumn = matrix[i, j];
                        minRowIndex = i;
                    }
                }

                // Міняємо місцями мінімальний елемент парного стовпця з максимальним елементом попереднього непарного стовпця
                int temp = matrix[maxRowIndex, j + 1];
                matrix[maxRowIndex, j + 1] = matrix[minRowIndex, j];
                matrix[minRowIndex, j] = temp;
            }
        }
    }
}
