﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity {  get; set; }
        public double FuelConsumption {  get; set; }

        public void Drive(double distance)
        {
            var fuelNeeded = this.FuelConsumption * distance / 100;

            if (fuelNeeded >= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;                
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            var result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"Fuel: {this.FuelQuantity:F2}");

            return result.ToString();
            
        }
    }
}
