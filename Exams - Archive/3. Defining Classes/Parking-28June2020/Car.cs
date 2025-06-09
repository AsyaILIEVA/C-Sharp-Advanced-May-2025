using System.ComponentModel;
using System.Reflection;

namespace Parking
{
//Your task is to create a repository, which stores items by creating the classes described below.
//First, write a C# class Car with the following properties:
//-Manufacturer: string
//-Model: string
//-Year: int
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

//The class constructor should receive the manufacturer, model and year and 
        public Car(string manufacturer, string model, int year)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
        }

// override the ToString() method in the following format:
//"{manufacturer} {model} ({year})"
        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year})";
        }
    }
}
