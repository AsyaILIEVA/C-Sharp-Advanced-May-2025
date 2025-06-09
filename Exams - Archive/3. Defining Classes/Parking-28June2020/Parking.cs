using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Parking
{
    //Next, write a C# class Parking that has data (a collection, which stores the entity Car).
    //All entities inside the repository have the same properties.
    public class Parking
    {
        private List<Car> data;//Field data – collection that holds added cars*

        //Also, the Parking class should have those properties:
        //Type: string
        //Capacity: int
        public string Type { get; set; }
        public int Capacity { get; set; }

        //The class constructor should receive type and capacity, 
        //also it should initialize the data with a new instance of the collection!!!
        //Implement the following features:
        //Field data – collection that holds added cars*
        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.data = new List<Car>();// !!!
        }

        //Method Add(Car car) – adds an entity to the data
        //if there is an empty cell for the car.
        public void Add(Car car)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(car);
            }
        }

        //Method Remove(string manufacturer, string model) 
        //    – removes the car by given manufacturer and model, if such exists, 
        //    and returns bool.
        public bool Remove(string manufacturer, string model)
        {
            if (this.data.Any(c => c.Manufacturer == manufacturer && c.Model == model))
            {
                Car foundedCar = this.data.Where(
                    c => c.Manufacturer == manufacturer && c.Model == model).First();
                this.data.Remove(foundedCar);
                return true;
            }
            return false;
        }

        //Method GetLatestCar() – returns the latest car(by year)
        //or null if it has no cars.
        public Car GetLatestCar()
        {
            if (this.data.Count > 0)
            {
                return this.data.OrderByDescending(c => c.Year).First();
            }
            return null;
        }

        //Method GetCar(string manufacturer, string model) – returns the car with the given manufacturer and model 
        //    or null if there is no such car.
        public Car GetCar(string manufacturer, string model)
        {
            if (this.data.Any(c => c.Manufacturer == manufacturer && c.Model == model))
            {
                Car foundedCar = this.data.Where(c => c.Manufacturer == manufacturer && c.Model == model).First();
                return foundedCar;
            }
            return null;
        }

        //Getter Count – returns the number of cars.
        public int Count => this.data.Count;

//GetStatistics() – returns a string in the following format:
//"The cars are parked in {parking type}:
//{Car1 }
//{Car2 }
//(…)"
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in this.data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
