using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Guild
{
    public class Player
    {
        //First, write a C# class Player with the following properties:
        //Name: string
        //Class: string
        //Rank: string – "Trial" by default
        //Description: string – "n/a" by default
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        //The class constructor should receive the name and class.
        public Player(string name, string class1)
        {
            Name = name;
            Class = class1;
            Rank = "Trial";
            Description = "n/a";
        }

        //Override the ToString() method in the following format:
        //"Player {Name}: {Class}
        //Rank: {Rank}
        //Description: {Description}
        //"

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Player {this.Name}: {this.Class}");
            sb.AppendLine($"Rank: {this.Rank}");
            sb.AppendLine($"Description: {this.Description}");

            return sb.ToString().TrimEnd();
        }
    
    }
}

