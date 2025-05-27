using System;
using System.Collections.Generic;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var symbol in text)
            {
                stack.Push(symbol);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
