using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            bool parentheses = true;
            var stack = new Stack<int>();


            foreach (var ch in input)
            {
                switch (ch)
                {
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '(':
                        stack.Push(')');
                        break;
                    case '}':
                    case ']':
                    case ')':
                        if (!stack.Any() || stack.Pop() != ch)
                        {
                            parentheses = false;
                        }
                        break;
                }
                if (!parentheses)
                {
                    break;
                }
            }
            if (parentheses)
            {
                Console.WriteLine("YES");
                Environment.Exit(0);
            }
            Console.WriteLine("NO");
        }
    }
}
