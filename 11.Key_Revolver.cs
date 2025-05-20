using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            var bulletsStack = new Stack<int>(bullets);
            var locksQueue = new Queue<int>(locks);

            int currentBarrel = gunBarrel;

            while (bulletsStack.Any() && locksQueue.Any())
            {
                int currentBullet = bulletsStack.Pop();
                int currentLock = locksQueue.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                intelligence -= bulletPrice;
                currentBarrel--;

                if (currentBarrel == 0 && bulletsStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = gunBarrel;
                }
            }

            if (!bulletsStack.Any() && locksQueue.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");

            }
            else
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligence}");
            }
        }
    }
}
