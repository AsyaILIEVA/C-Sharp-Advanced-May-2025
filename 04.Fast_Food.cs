using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int biggestOrder = orders.Max();
            while (orders.Count > 0)
            {
                if (food < orders.Peek())
                    break;

                food -= orders.Dequeue();
            }
            Console.WriteLine(biggestOrder);

            if (orders.Count == 0) Console.WriteLine("Orders complete");
            else Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        }
    }
}
