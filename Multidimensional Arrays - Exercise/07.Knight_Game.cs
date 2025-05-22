using System;

namespace _07.Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[,] matrix = new bool[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)                
                    matrix[i, j] = (input[j] == 'K');                 
            }

            int actions = 0;
            bool checkForConflicts = true;
            while (checkForConflicts)
            {
                int maxConflicts = 0, maxConflictsRow = -1, maxConflictsCol = -1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (!matrix[i, j]) continue;

                        int conflicts = CountConflicts(matrix, i, j);
                        if (conflicts > maxConflicts)
                        {
                            maxConflicts = conflicts;
                            maxConflictsRow = i;
                            maxConflictsCol = j;
                        }
                    }
                }
                if (maxConflicts == 0)
                {
                    checkForConflicts = false;
                }
                else
                {
                    matrix[maxConflictsRow, maxConflictsCol] = false;
                    actions++;
                }

            }

            Console.WriteLine(actions);

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (matrix[i, j])
            //        {
            //            Console.WriteLine($"i = {i}; j = {j}; conflicts = {CountConflicts(matrix, i, j)}");
            //        }
                    
            //    }

            //}
        }

            static int[,] moves =
            {
                { 1, 2 },
                { 1, -2 },
                { -1, 2 },
                { -1, -2 },
                { 2, 1 },
                { 2, -1 },
                { -2, 1 },
                { -2, -1 }
            };

        static int CountConflicts(bool[,] matrix,int row, int col)
        {
            int count = 0;
            for (int i = 0; i < moves.GetLength(0); i++)
            {
                int nextRow = row + moves[i, 0], nextCol = col + moves[i, 1];
                if (nextRow < 0 || nextRow >= matrix.GetLength(0)
                    || nextCol < 0 || nextCol >= matrix.GetLength(1))
                    continue;

                if (matrix[nextRow, nextCol])
                    count++;
            }

            return count;

        }
            
    }
}
