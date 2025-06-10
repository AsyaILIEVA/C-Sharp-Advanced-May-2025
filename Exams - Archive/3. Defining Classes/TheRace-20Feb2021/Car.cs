using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TheRace
{
    public class Car
    {
        //First, write a C# class Car with the following properties:
        //Name: string
        //Speed: int
        //The class constructor should receive name, and speed.

        public string Name { get; set; }
        public int Speed { get; set; }

        public Car(string name, int speed) 
        { 
            Name = name;
            Speed = speed;
        }
    }
}
