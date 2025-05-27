using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_And_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] queryData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (queryData[0] == 1) stack.Push(queryData[1]);
                else if (queryData[0] == 2) stack.Pop();
                else if (stack.Count > 0)
                {
                    if (queryData[0] == 3) Console.WriteLine(stack.Max());
                    else if (queryData[0] == 4) Console.WriteLine(stack.Min());
                    
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
