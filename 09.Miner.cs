using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> moves = new Dictionary<string, int[]> 
            { 
                ["up"] = new[] {-1,0},
                ["right"] = new[] {0,1},
                ["down"] = new[] {1,0},
                ["left"] = new[] {0,-1},
            
            }; 

            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                char[] values = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = values[j];
                }

            }
            (int row, int col) = Find(matrix, 's');
            int coals = Count(matrix, 'c');

            bool gameOver = false;
            foreach (var command in commands)
            {
                int[] change = moves[command];
                int nextRow = row + change[0], nextCol = col + change[1];
                if (nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n)
                {
                    continue;
                }
                row = nextRow;
                col = nextCol;

                //if (matrix[nextRow,nextCol] == 'c')
                //{
                //    coals--;
                //    matrix[nextRow, nextCol] = '*';
                //}
                if (matrix[row,col] == 'c')
                {
                    //coals--;
                    matrix[row, col] = '*';
                    if (--coals == 0) break;
                }
                //else if (matrix[nextRow, nextCol] == 'e')
                else if (matrix[row, col] == 'e')
                {
                    gameOver = true;
                    break;
                }
            }
            if (gameOver)
            {
                Console.WriteLine($"Game over! ({row}, {col})");
            }
            else if (coals == 0)
            {
                Console.WriteLine($"You collected all coals! ({row}, {col})");
            }
            else
            {
                Console.WriteLine($"{coals} coals left. ({row}, {col})");
            }
        }
        static(int, int)Find(char[,] matrix, char symbol)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == symbol)
                    {
                        return (i, j);
                    }
                }

            }
            throw new InvalidOperationException("Start not found");
        }
        static int Count(char[,] matrix, char symbol)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
