using System;
using System.Linq;

namespace _03.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int[,] squareMatrix = new int[3, 3];
            int sum = int.MinValue;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = matrix[row, col] +
                                        matrix[row, col + 1] +
                                        matrix[row, col + 2] +
                                        matrix[row + 1, col] +
                                        matrix[row + 1, col + 1] +
                                        matrix[row + 1, col + 2] +
                                        matrix[row + 2, col] +
                                        matrix[row + 2, col + 1] +
                                        matrix[row + 2, col + 2];

                    if (currentSum > sum)
                    {
                        squareMatrix[0, 0] = matrix[row, col];
                        squareMatrix[0, 1] = matrix[row, col + 1];
                        squareMatrix[0, 2] = matrix[row, col + 2];
                        squareMatrix[1, 0] = matrix[row + 1, col];
                        squareMatrix[1, 1] = matrix[row + 1, col + 1];
                        squareMatrix[1, 2] = matrix[row + 1, col + 2];
                        squareMatrix[2, 0] = matrix[row + 2, col];
                        squareMatrix[2, 1] = matrix[row + 2, col + 1];
                        squareMatrix[2, 2] = matrix[row + 2, col + 2];

                        sum = currentSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    Console.Write($"{squareMatrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
