using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(numbers);
            
            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }
                if (command.StartsWith("add"))
                {
                    var cmdArgs = command.Split(" ");
                    int firstNumber = int.Parse(cmdArgs[1]);
                    int secondNumber = int.Parse(cmdArgs[2]);

                    stack.Push(firstNumber);                    
                    stack.Push(secondNumber);
                    
                }
                if (command.StartsWith("remove"))
                {
                    var cmdArgs = command.Split(" ");
                    var elements = int.Parse(cmdArgs[1]);

                    if (elements <= stack.Count)
                    {
                        for (int i = 0; i < elements; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine(value: $"Sum: {stack.Sum()}");
        }
    }
}
