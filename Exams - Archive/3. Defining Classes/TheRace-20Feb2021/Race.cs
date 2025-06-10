using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        //Next, write a C# class Race that has data (a collection, which stores the entity Racer). All entities inside the repository have the same properties. Also, the Race class should have those properties:
        //Name: string
        //Capacity: int
        List<Racer> data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        //The class constructor should receive name and capacity(the maximum allowed number of racers), also it should initialize the data with a new instance of the collection.Implement the following features:
        //Field data – collection that holds added Racers
        public Race(string name, int capacity)
            
        {
            data = new List<Racer>();
            Name = name;
            Capacity = capacity;
        }
        //Method Add(Racer Racer) – adds an entity to the data if there is room for him/her.
        public void Add(Racer Racer)
        {
            if (Capacity > data.Count)
            {
                data.Add(Racer);
            }
        }       
        
        //Method Remove(string name) – removes a Racer by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            if (data.Any(r => r.Name == name))
            {
                Racer removedRacer = data.Where(r => r.Name == name).First();
                data.Remove(removedRacer);
                return true;
            }
            return false;
        }
        //Method GetOldestRacer() – returns the oldest Racer.
        public Racer GetOldestRacer()
        {           
                Racer oldestRacer = data.OrderByDescending(r => r.Age).First();
                return oldestRacer;            
        }

        //Method GetRacer(string name) – returns the Racer with the given name.
        public Racer GetRacer(string name)
        {
            Racer racer = data.FirstOrDefault(r => r.Name == name);
            return racer;
        }
        
        //Method GetFastestRacer() – returns the Racer whose car has the highest speed.
        public Racer GetFastestRacer()
        {
            Racer fastestCar = data.OrderByDescending(c => c.Car.Speed).First();
            return fastestCar;
        }

        //Getter Count – returns the number of Racers.
        public int Count => data.Count;

        //Report() – returns a string in the following format:
        //o"Racers participating at {RaceName}:
        //{ Racer1}
        //{ Racer2}
        //(…)"

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");

            foreach (var racer in data)
            {
                sb.AppendLine($"{racer}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
