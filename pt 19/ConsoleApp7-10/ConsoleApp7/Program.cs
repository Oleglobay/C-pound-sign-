using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            int[,] matrix = CreateRandomMatrix(n);

            Console.WriteLine("Початкова матриця:");
            PrintMatrix(matrix);

            SortMainDiagonalAscending(matrix);
            Console.WriteLine("\nМатриця з впорядкованою головною діагоналлю за зростанням:");
            PrintMatrix(matrix);

            SortMainDiagonalDescending(matrix);
            Console.WriteLine("\nМатриця з впорядкованою головною діагоналлю за спаданням:");
            PrintMatrix(matrix);

            SortSecondaryDiagonalAscending(matrix);
            Console.WriteLine("\nМатриця з впорядкованою побічною діагоналлю за зростанням:");
            PrintMatrix(matrix);

            SortSecondaryDiagonalDescending(matrix);
            Console.WriteLine("\nМатриця з впорядкованою побічною діагоналлю за спаданням:");
            PrintMatrix(matrix);
        }

        static int[,] CreateRandomMatrix(int n)
        {
            Random random = new Random();
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-10, 11);
                }
            }
            return matrix;
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

        static void SortMainDiagonalAscending(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, i] > matrix[j, j])
                    {
                        int temp = matrix[i, i];
                        matrix[i, i] = matrix[j, j];
                        matrix[j, j] = temp;
                    }
                }
            }
        }

        static void SortMainDiagonalDescending(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, i] < matrix[j, j])
                    {
                        int temp = matrix[i, i];
                        matrix[i, i] = matrix[j, j];
                        matrix[j, j] = temp;
                    }
                }
            }
        }

        static void SortSecondaryDiagonalAscending(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, n - 1 - i] > matrix[j, n - 1 - j])
                    {
                        int temp = matrix[i, n - 1 - i];
                        matrix[i, n - 1 - i] = matrix[j, n - 1 - j];
                        matrix[j, n - 1 - j] = temp;
                    }
                }
            }
        }

        static void SortSecondaryDiagonalDescending(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, n - 1 - i] < matrix[j, n - 1 - j])
                    {
                        int temp = matrix[i, n - 1 - i];
                        matrix[i, n - 1 - i] = matrix[j, n - 1 - j];
                        matrix[j, n - 1 - j] = temp;
                    }
                }
            }
        }
    }
}
