using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CocktailParty
{
    public class Ingredient
    {
        //First, write a C# class, called Ingredient with properties:
        //Name: string
        //Alcohol: int
        //Quantity: int
        public string Name { get; set; }
        public int Alcohol { get; set; }
        public int Quantity { get; set; }

        //The constructor of Ingredient class should receive name, alcohol and quantity.
        public Ingredient(string name, int alcohol, int quantity) 
        {
            Name = name;
            Alcohol = alcohol;
            Quantity = quantity;
        }
        //The class should also have the following methods:
        //Override ToString() method in the format:
        //"Ingredient: {Name}
        // Quantity: {Quantity}
        // Alcohol: {Alcohol}"

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ingredient: {this.Name}");
            sb.AppendLine($"Quantity: {this.Quantity}");
            sb.AppendLine($"Alcohol: {this.Alcohol}");

            return sb.ToString().TrimEnd();
        }
        }
}
