using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var text = new StringBuilder();

            var stack = new Stack<string>();

            stack.Push(text.ToString());


            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        text.Append(command[1]);
                        stack.Push(text.ToString());
                        break;
                    case "2":
                        text.Remove(text.Length - int.Parse(command[1]), int.Parse(command[1]));
                        stack.Push(text.ToString());
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(command[1]) - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        text = new StringBuilder(stack.Peek());
                        break;    
                }
            }

        }
    }
}
