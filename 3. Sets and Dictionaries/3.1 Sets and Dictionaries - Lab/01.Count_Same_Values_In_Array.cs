using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Same_Values_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var dict = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!dict.ContainsKey(number))
                {
                    dict[number] = 1;
                }
                else
                {
                    dict[number]++;
                }
            }
            foreach (var entry in dict)
            {
                var key = entry.Key;
                var value = entry.Value;

                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
