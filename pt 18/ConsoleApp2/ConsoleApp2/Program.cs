using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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

            int sumMaxInEvenColumns = SumMaxInEvenColumns(matrix);
            int sumMinInEvenColumns = SumMinInEvenColumns(matrix);
            int sumMaxInOddColumns = SumMaxInOddColumns(matrix);
            int sumMinInOddColumns = SumMinInOddColumns(matrix);

            Console.WriteLine($"Сума максимальних елементів в парних стовпцях: {sumMaxInEvenColumns}");
            Console.WriteLine($"Сума мінімальних елементів в парних стовпцях: {sumMinInEvenColumns}");
            Console.WriteLine($"Сума максимальних елементів в непарних стовпцях: {sumMaxInOddColumns}");
            Console.WriteLine($"Сума мінімальних елементів в непарних стовпцях: {sumMinInOddColumns}");
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
