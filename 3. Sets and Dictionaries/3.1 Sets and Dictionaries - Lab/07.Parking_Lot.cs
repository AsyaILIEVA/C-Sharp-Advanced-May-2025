using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new HashSet<string>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                var commandParts = command
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var direction = commandParts[0];
                var carNumber = commandParts[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else if(direction == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }
            }
            if (parkingLot.Any())
            {
                foreach (var carNumber in parkingLot)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
