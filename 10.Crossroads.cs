using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            var stack = new Stack<string>();

            var command = Console.ReadLine();

            while (command != "END")
            {
                if (command != "green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    int greenLight = greenLightDuration;
                    int freePass = freeWindow;

                    int counter = queue.Count;

                    for (int i = 0; i < counter; i++)
                    {
                        if (greenLight >= queue.Peek().Length && queue.Any())
                        {
                            greenLight -= queue.Peek().Length;
                            stack.Push(queue.Dequeue());
                        }
                        else if (greenLight < queue.Peek().Length && queue.Any())
                        {
                            int neededSeconds = greenLight + freePass;

                            if (greenLight <= 0)
                            {
                                continue;
                            }
                            else if (neededSeconds > 0 && neededSeconds >= queue.Peek().Length)
                            {
                                string car = queue.Peek();
                                neededSeconds -= car.Length;
                                stack.Push(queue.Dequeue());
                                greenLight = 0;
                                freePass = 0;
                            }
                            else if (neededSeconds > 0 && neededSeconds < queue.Peek().Length)
                            {
                                string car = queue.Peek();

                                Console.WriteLine("A crash happened!");
                                int hit = neededSeconds;
                                Console.WriteLine($"{car} was hit at {car[hit]}.");
                                return;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{stack.Count} total cars passed the crossroads.");
        }
    }
}
