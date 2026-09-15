using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
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

            SortMainDiagonal(matrix);

            Console.WriteLine("Матриця з впорядкованими елементами головної діагоналі:");
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

        static void SortMainDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);


            int[] diagonalElements = new int[n];


            for (int i = 0; i < n; i++)
            {
                diagonalElements[i] = matrix[i, i];
            }

            Array.Sort(diagonalElements);


            for (int i = 0; i < n; i++)
            {
                matrix[i, i] = diagonalElements[i];
            }
        }
    }
}
