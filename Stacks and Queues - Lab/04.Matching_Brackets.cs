using System;
using System.Collections.Generic;

namespace _04.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                var symbol = expression[i];
                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    var openingBracketIndex = stack.Pop();
                    var closingBracketIndex = i;

                    var result = expression.Substring(
                        openingBracketIndex, closingBracketIndex - openingBracketIndex + 1);

                    Console.WriteLine(result);
                }
            }
        }
    }
}
