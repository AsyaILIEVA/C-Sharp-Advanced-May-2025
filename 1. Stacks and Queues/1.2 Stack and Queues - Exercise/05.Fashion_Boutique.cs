using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());

            int racks = 0, free = 0;
            while (clothes.Count > 0)
            {
                int currentElement = clothes.Pop();

                if (free < currentElement)
                {
                    racks++;
                    free = capacity;
                }
                free -= currentElement;
            }
            Console.WriteLine(racks);

        }
    }
}
