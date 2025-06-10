using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;

namespace TheRace
{
    public class Racer
    {
        //Next, write a C# class Racer with the following properties:
        //Name: string
        //Age: int
        //Country: string
        //Car: Car
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Car Car { get; set; }

        //The class constructor should receive name, age, country and Car and override the ToString() method in the following format:
        //"Racer: {name}, {age} ({country})"

        public Racer(string name, int age, string country, Car car) 
        {
            Name = name;
            Age = age;
            Country = country;
            Car = car;
        
        }

        public override string ToString()
        {
            return $"Racer: {Name}, {Age} ({Country})";
        }

        

    }
}
