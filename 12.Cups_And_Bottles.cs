using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Cups_And_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bottles = new Stack<int>(filledBottles);
            var cups = new Stack<int>(cupsCapacity.Reverse());

            var wastedWater = 0;

            while (bottles.Any() && cups.Any())
            {
                int bottle = bottles.Pop();
                int cup = cups.Peek();

                if (cup <= bottle)
                {
                    wastedWater += bottle - cup;
                    cups.Pop();
                }
                else
                {
                    cups.Pop();
                    cups.Push(cup - bottle);
                }
            }
            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
