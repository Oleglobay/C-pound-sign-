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
            int[,] matrix = GenerateMatrix(10, 10);

            Console.WriteLine("Початкова матриця:");
            PrintMatrix(matrix);

            SortMatrix(matrix);

            Console.WriteLine("Відсортована матриця:");
            PrintMatrix(matrix);
        }

        static int[,] GenerateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(100); 
                }
            }

            return matrix;
        }

        static void SortMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[] flattenedMatrix = new int[rows * columns];

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    flattenedMatrix[index] = matrix[i, j];
                    index++;
                }
            }

            Array.Sort(flattenedMatrix);

            index = 0;
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix[i, j] = flattenedMatrix[index];
                    index++;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
