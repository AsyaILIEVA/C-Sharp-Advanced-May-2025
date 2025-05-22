using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            HashSet<string> uniqueNames = new HashSet<string>();

            string[] initialSongs = Console.ReadLine().Split(", ");
            foreach (var song in initialSongs)
            {
                if (uniqueNames.Add(song))
                    queue.Enqueue(song);
            }

            while (queue.Count > 0)
            {
                string[] data = Console.ReadLine().Split();
                string command = data[0];

                if (command == "Add")
                {
                    string song = string.Join(" ", data.Skip(1));

                    if (uniqueNames.Add(song))
                        queue.Enqueue(song);
                    else
                        Console.WriteLine($"{song} is already contained!");

                }
                else if (command == "Play")
                {
                    string removedSong = queue.Dequeue();
                    uniqueNames.Remove(removedSong);                    
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
