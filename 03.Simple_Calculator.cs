using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console
                .ReadLine()
                .Split()
                .Reverse()
                .ToArray();

            var stack = new Stack<string>(tokens);
            bool isAddition = true;
            int sum = 0;

            while (stack.Count > 0)
            {
                var currentToken = stack.Pop();
                if (currentToken == "+")
                {
                    isAddition = true;
                }
                else if (currentToken == "-")
                {
                    isAddition = false;
                }
                else
                {
                    int number = int.Parse(currentToken);
                    if (!isAddition)
                    {
                        number *= -1;
                    }
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
