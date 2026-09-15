using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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

            SwapMinMaxAboveAndBelowSecondaryDiagonal(matrix);

            Console.WriteLine("Матриця після заміни:");
            PrintMatrix(matrix);

            int sum = SumMinMaxAboveAndBelowSecondaryDiagonal(matrix);
            Console.WriteLine($"Сума мінімального елементу над побічною діагоналлю та максимального елементу під побічною діагоналлю: {sum}");
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

        static void SwapMinMaxAboveAndBelowSecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            int minAboveDiagonal = matrix[0, n - 2];
            int maxBelowDiagonal = matrix[1, n - 1];
            int minRowIndex = 0;
            int maxRowIndex = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j && i + j < n - 1 && matrix[i, j] < minAboveDiagonal)
                    {
                        minAboveDiagonal = matrix[i, j];
                        minRowIndex = i;
                    }

                    if (i > j && i + j > n - 1 && matrix[i, j] > maxBelowDiagonal)
                    {
                        maxBelowDiagonal = matrix[i, j];
                        maxRowIndex = i;
                    }
                }
            }

            
            int temp = matrix[minRowIndex, n - 2];
            matrix[minRowIndex, n - 2] = matrix[maxRowIndex, n - 1];
            matrix[maxRowIndex, n - 1] = temp;
        }

        static int SumMinMaxAboveAndBelowSecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            int minAboveDiagonal = matrix[0, n - 2];
            int maxBelowDiagonal = matrix[1, n - 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j && i + j < n - 1 && matrix[i, j] < minAboveDiagonal)
                    {
                        minAboveDiagonal = matrix[i, j];
                    }

                    if (i > j && i + j > n - 1 && matrix[i, j] > maxBelowDiagonal)
                    {
                        maxBelowDiagonal = matrix[i, j];
                    }
                }
            }

            return minAboveDiagonal + maxBelowDiagonal;
        }
    }
}
