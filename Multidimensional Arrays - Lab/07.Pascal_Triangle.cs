using System;

namespace _07.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum[r, c] = [r-1,c] + [r-1, c-1] Pascal Triangle

            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];
            for (int row = 0; row < n; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] =
                        triangle[row - 1][col - 1] +
                        triangle[row - 1][col];
                }
                triangle[row][row] = 1;
            }
            //Print the jagged array
            for (int row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine(string.Join(" ", triangle[row]));
            }
        }
    }
}
