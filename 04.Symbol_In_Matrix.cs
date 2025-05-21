using System;

namespace _04.Symbol_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        int currRow = row;
                        int currCol = col;
                        Console.WriteLine($"({currRow}, {currCol})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
