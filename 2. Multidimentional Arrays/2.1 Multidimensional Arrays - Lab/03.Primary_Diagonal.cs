﻿using System;
using System.Linq;

namespace _03.Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            long sum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = row; col <= row; col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
