using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double travelledDistance;

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public double FuelAmount
        {
            get => this.fuelAmount;
            set => this.fuelAmount = value;
        }

        public double FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }

        public double TravelledDistance
        {
            get => this.travelledDistance;
            set => this.travelledDistance = value;
        }

        public Car(string model, double fuelAmount, double fuelConsumption) 
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;        
        }

        public bool Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if(this.FuelAmount < neededFuel) return false;

            this.FuelAmount -= neededFuel;
            this.TravelledDistance += distance;
            return true;            
        }
    }
}
