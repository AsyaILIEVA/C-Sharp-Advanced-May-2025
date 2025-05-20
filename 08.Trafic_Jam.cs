using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();

            int totalCarsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Any())
                        {
                            var currentCar = cars.Dequeue();

                            Console.WriteLine($"{currentCar} passed!");

                            totalCarsPassed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

            }
            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
