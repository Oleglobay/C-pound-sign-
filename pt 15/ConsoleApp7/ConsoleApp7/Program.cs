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
            int[,] matrix = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Початковий масив:");
            PrintMatrix(matrix);

            int[,] mirroredMatrix = MirrorMatrix(matrix);
            Console.WriteLine("\nДзеркальний масив:");
            PrintMatrix(mirroredMatrix);

            int[,] modifiedMatrix = ModifyMatrix(mirroredMatrix);
            Console.WriteLine("\nМодифікований масив:");
            PrintMatrix(modifiedMatrix);

            int sum = CalculateSum(modifiedMatrix);
            Console.WriteLine("\nСума непарних елементів (окрім 1): " + sum);

            int[,] rotatedMatrix = RotateMatrix(modifiedMatrix);
            Console.WriteLine("\nМатриця після повороту на 90 градусів:");
            PrintMatrix(rotatedMatrix);

            Console.ReadLine();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] MirrorMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] mirroredMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mirroredMatrix[i, j] = matrix[j, i];
                }
            }

            return mirroredMatrix;
        }

        static int[,] ModifyMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] modifiedMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 && j == 0 || i == 0 && j == cols - 1 || i == rows - 1 && j == 0 || i == rows - 1 && j == cols - 1)
                    {
                        modifiedMatrix[i, j] = matrix[i, j] * -1;
                    }
                    else if (matrix[i, j] % 2 == 0)
                    {
                        modifiedMatrix[i, j] = 1;
                    }
                    else
                    {
                        modifiedMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            return modifiedMatrix;
        }

        static int CalculateSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0 && matrix[i, j] != 1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }

        static int[,] RotateMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] rotatedMatrix = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rotatedMatrix[j, rows - 1 - i] = matrix[i, j];
                }
            }

            return rotatedMatrix;
            Console.ReadKey();
        }
    }
}
