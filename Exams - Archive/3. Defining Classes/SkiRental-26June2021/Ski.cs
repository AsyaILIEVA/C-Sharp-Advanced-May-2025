using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;//ctrl r ctrl g

namespace SkiRental
{
    public class Ski
    {
        // => ctrl /
        //First, write a C# class Ski with the following properties:
        //Manufacturer: string
        //Model: string
        //Year: int
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //The class constructor should receive the manufacturer, model and year and override the ToString() method in the following format:
        //"{manufacturer} - {model} - {year}"
        public Ski(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Manufacturer} - {Model} - {Year}";
        }
    }
}
