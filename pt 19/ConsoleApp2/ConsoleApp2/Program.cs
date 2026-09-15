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

            SwapMaxMinInColumns(matrix);

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

        static void SwapMaxMinInColumns(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 0; j < m; j++)
            {
                int minInColumn = matrix[0, j];
                int maxInColumn = matrix[0, j];
                int minRowIndex = 0;
                int maxRowIndex = 0;

                for (int i = 1; i < n; i++)
                {
                    if (matrix[i, j] < minInColumn)
                    {
                        minInColumn = matrix[i, j];
                        minRowIndex = i;
                    }

                    if (matrix[i, j] > maxInColumn)
                    {
                        maxInColumn = matrix[i, j];
                        maxRowIndex = i;
                    }
                }

                if (j % 2 == 0)
                {
                    
                    int temp = matrix[minRowIndex, j];
                    matrix[minRowIndex, j] = matrix[maxRowIndex, j];
                    matrix[maxRowIndex, j] = temp;
                }
                else
                {
                    
                    int temp = matrix[minRowIndex, j];
                    matrix[minRowIndex, j] = matrix[maxRowIndex, j];
                    matrix[maxRowIndex, j] = temp;
                }
            }
        }
    }
}
