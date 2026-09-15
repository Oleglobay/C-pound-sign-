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
            int n = 5;

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

            SwapRowsToMaxOnDiagonal(matrix);

            Console.WriteLine("Матриця після заміни:");
            PrintMatrix(matrix);
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

        static void SwapRowsToMaxOnDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                int maxInRow = matrix[i, 0];
                int maxColIndex = 0;


                for (int j = 1; j < n; j++)
                {
                    if (matrix[i, j] > maxInRow)
                    {
                        maxInRow = matrix[i, j];
                        maxColIndex = j;
                    }
                }


                if (i != maxColIndex)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[j, i];
                        matrix[j, i] = temp;
                    }
                }
            }
        }
    }
}
