using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var make = Console.ReadLine();
            var model = Console.ReadLine();
            var year = int.Parse(Console.ReadLine());
            var fuelQuantity = double.Parse(Console.ReadLine());
            var fuelConsumption = double.Parse(Console.ReadLine());

            var firstCar = new Car();
            var secondCar = new Car(make, model, year);
            var thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            var tires = new Tire[]
            {
                new Tire(2025, 2.3),
                new Tire(2025, 2.3),
                new Tire(2025, 2.5),
                new Tire(2025, 2.5)
            };

            var engine = new Engine(horsePower: 530, cubicCapacity: 3.0);

            var car = new Car(
                "Lamborghini",
                "Revuelto",
                year: 2025, 
                fuelQuantity: 100,
                fuelConsumption: 16, 
                engine, 
                tires);
            

            //var car = new Car
            //{
            //    Make = "BMW",
            //    Model = "M850i",
            //    Year = 2021,
            //    FuelQuantity = 100,
            //    FuelConsumption = 13.5

            //};

        }
    }
}

