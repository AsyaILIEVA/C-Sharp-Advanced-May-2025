﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(input);

            for (int i = 0; i < input.Length; i++)
            {
                queue.Dequeue();
                if (input[i] % 2 == 0)
                {
                    queue.Enqueue(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
