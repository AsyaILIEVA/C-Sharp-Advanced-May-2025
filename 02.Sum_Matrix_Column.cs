using System;
using System.Linq;

namespace _02.Sum_Matrix_Columns
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
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            long sum = 0;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
