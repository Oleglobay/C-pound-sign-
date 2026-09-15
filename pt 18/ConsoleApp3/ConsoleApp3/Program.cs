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

            SwapMaxMinBetweenRows(matrix);

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

        static void SwapMaxMinBetweenRows(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 1; i < n; i += 2)
            {
                int prevRow = i - 1;
                int maxInRow = matrix[i, 0];
                int minInPrevRow = matrix[prevRow, 0];
                int maxColIndex = 0;
                int minColIndex = 0;

                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] > maxInRow)
                    {
                        maxInRow = matrix[i, j];
                        maxColIndex = j;
                    }

                    if (matrix[prevRow, j] < minInPrevRow)
                    {
                        minInPrevRow = matrix[prevRow, j];
                        minColIndex = j;
                    }
                }

              
                int temp = matrix[i, maxColIndex];
                matrix[i, maxColIndex] = matrix[prevRow, minColIndex];
                matrix[prevRow, minColIndex] = temp;
            }
    }
}
