using System;
using System.Collections.Generic;

namespace _08.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularGuests = new HashSet<string>();
            var vipGuests = new HashSet<string>();

            var isParty = false;

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var reservationNumber = command;

                if (command == "PARTY")
                {
                    isParty = true;
                    continue;
                }

                if (isParty)
                {
                    if (regularGuests.Contains(reservationNumber))
                    {
                        regularGuests.Remove(reservationNumber);
                    }

                    if (vipGuests.Contains(reservationNumber))
                    {
                        vipGuests.Remove(reservationNumber);
                    }
                }
                    
                

                else
                {
                    var firstNumber = reservationNumber[0];
                    var isVip = char.IsDigit(firstNumber);

                    if (isVip)
                    {
                        vipGuests.Add(reservationNumber);
                    }
                    else
                    {
                        regularGuests.Add(reservationNumber);
                    }
                }
            }
            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach (var regularGuest in regularGuests)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}
