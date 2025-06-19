using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        //Next, write a C# class SkiRental that has data (a collection, which stores the entity Ski). All entities inside the repository have the same properties. Also, the Ski Rental class should have those properties:
        //Name: string
        //Capacity: int
        List<Ski> data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        //The class constructor should receive name and capacity, also it should initialize the data with a new instance of the collection.Implement the following features:
        //Field data – collection that holds added Skis

        public SkiRental(string name, int capacity) 
        { 
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        //Method Add(Ski ski) – adds an entity to the data if there is an empty slot for the Ski.
        public void Add(Ski ski)
        {
            if (Capacity > data.Count)
            {
                data.Add(ski);
            }
        }
        
        //Method Remove(string manufacturer, string model) – removes the Ski by given manufacturer and model, if such exists, and returns a bool.
        public bool Remove(string manufacturer, string model)
        {
            if (data.Any(s => s.Manufacturer == manufacturer && s.Model == model))
            {
                Ski removedItem = data.Where(s => s.Manufacturer == manufacturer && s.Model == model).FirstOrDefault();
                data.Remove(removedItem);
                return true;
            }
            return false;
        }
        //Method GetNewestSki() – returns the newest Ski (by year) or null if there are no Skis stored.
        public Ski GetNewestSki()
        {
            if (data.Count > 0)
            {
                Ski newestSki = data.OrderByDescending(s => s.Year).First();
                return newestSki;
            }
            return null;
        }
        //Method GetSki(string manufacturer, string model) – returns the Ski with the given manufacturer and model or null if there is no such Ski.
        public Ski GetSki(string manufacturer, string model)
        {
            if (data.Any(s => s.Manufacturer == manufacturer && s.Model == model))
            {
                Ski specificSki = data.Where(s => s.Manufacturer == manufacturer && s.Model == model).First();
                return specificSki;
            }
            return null;
        }

        //Getter Count – returns the number of Skis.
        public int Count => data.Count;

        //GetStatistics() – returns a string in the following format:
        //o"The skis stored in {Ski Rental Name}:
        //{ Ski1}
        //{Ski2 }
        //(…)"

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");

            foreach (var ski in data)
            {
                sb.AppendLine($"{ski}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
