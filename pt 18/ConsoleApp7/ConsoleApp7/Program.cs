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

            SwapMinMaxInEvenRows(matrix);

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

        static void SwapMinMaxInEvenRows(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i += 2)
            {
                int maxInRow = matrix[i, 0];
                int minInRow = matrix[i, 0];
                int maxColIndex = 0;
                int minColIndex = 0;

                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] > maxInRow)
                    {
                        maxInRow = matrix[i, j];
                        maxColIndex = j;
                    }

                    if (matrix[i, j] < minInRow)
                    {
                        minInRow = matrix[i, j];
                        minColIndex = j;
                    }
                }

                
                int temp = matrix[i, maxColIndex];
                matrix[i, maxColIndex] = matrix[i, minColIndex];
                matrix[i, minColIndex] = temp;
            }
        }
    }
}
