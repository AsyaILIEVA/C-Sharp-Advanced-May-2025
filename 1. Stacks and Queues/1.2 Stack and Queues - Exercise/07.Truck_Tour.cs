using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pumpInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(pumpInfo);
            }

            int index = 0;


            while (true)
            {
                int fuel = 0;
                foreach (int[] petrolPump in queue)
                {
                    fuel += petrolPump[0] - petrolPump[1];
                    if (fuel < 0)
                    {
                        index++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        break;
                    }
                }

                if (fuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
