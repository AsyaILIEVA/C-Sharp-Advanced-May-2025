using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer

{
    public class StartUp
    {
        static void Main()
        {
            var car = new Car
            {
                Make = "BMW",
                Model = "M850i",
                Year = 2021

            };

            Console.WriteLine($"Make: {car.Make} \r\nModel: {car.Model} \r\nProduction Year: {car.Year}");
        }
    }
}
