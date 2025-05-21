using System;
using System.Linq;

namespace _05.Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            long maxSum = long.MinValue;
            string bestSquare2x2 = " ";
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    long sum = matrix[row, col] +
                                matrix[row, col + 1] +
                                matrix[row + 1, col] +
                                matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestSquare2x2 = matrix[row, col] + " " +
                                matrix[row, col + 1] + " \r\n" +
                                matrix[row + 1, col] + " " +
                                matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine(bestSquare2x2);
            Console.WriteLine(maxSum);
        }
    }
}
