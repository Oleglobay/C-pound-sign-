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

            Console.WriteLine("Парні стовпці матриці:");
            PrintEvenColumns(matrix);

            Console.WriteLine("Непарні стовпці матриці:");
            PrintOddColumns(matrix);

            int maxInEvenColumns = FindMaxInEvenColumns(matrix);
            int minInEvenColumns = FindMinInEvenColumns(matrix);
            int maxInOddColumns = FindMaxInOddColumns(matrix);
            int minInOddColumns = FindMinInOddColumns(matrix);

            Console.WriteLine($"Максимальний елемент в парних стовпцях: {maxInEvenColumns}");
            Console.WriteLine($"Мінімальний елемент в парних стовпцях: {minInEvenColumns}");
            Console.WriteLine($"Максимальний елемент в непарних стовпцях: {maxInOddColumns}");
            Console.WriteLine($"Мінімальний елемент в непарних стовпцях: {minInOddColumns}");
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

        static void PrintEvenColumns(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 1; j < m; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintOddColumns(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 0; j < m; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int FindMaxInEvenColumns(int[,] matrix)
        {
            int max = int.MinValue;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 1; j < m; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            return max;
        }

        static int FindMinInEvenColumns(int[,] matrix)
        {
            int min = int.MaxValue;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 1; j < m; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            return min;
        }

        static int FindMaxInOddColumns(int[,] matrix)
        {
            int max = int.MinValue;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 0; j < m; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            return max;
        }

        static int FindMinInOddColumns(int[,] matrix)
        {
            int min = int.MaxValue;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 0; j < m; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            return min;
        }
    }
}
