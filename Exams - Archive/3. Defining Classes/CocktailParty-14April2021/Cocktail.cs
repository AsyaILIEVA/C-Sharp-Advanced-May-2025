using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CocktailParty
{
    public class Cocktail
    {
//Next step is to write Cocktail class that has a collection of type Ingredient with corresponding unique name of an Ingredient.The name of the collection should be Ingredients.All the entities of the Ingredients collection have the same properties. The Cocktail has also some additional properties:
//Name: string
//Capacity: int - the maximum allowed number of ingredients in the cocktail
//MaxAlcoholLevel: int - the maximum allowed amount of alcohol in the cocktail
        List<Ingredient> ingredients;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        //The constructor of the Cocktail class should receive name, capacity and maxAlcoholLevel.
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;

            ingredients = new List<Ingredient>();
        }
//Implement the coming features:
//Method Add(Ingredient ingredient) - adds the entity if there isn't an Ingredient with the same name and if there is enough space in terms of quantity and alcohol.
public void Add(Ingredient ingredient)
        {
            if (!ingredients.Contains(ingredient)
                && ingredients.Count < Capacity
                && ingredient.Alcohol < MaxAlcoholLevel)
            {
                ingredients.Add(ingredient);
            }
        }
//Method Remove(string name) - removes an Ingredient from the cocktail with the given name, if such exists and returns bool if the deletion is successful.
public bool Remove(string name)
        {
            if (ingredients.Any(i => i.Name == name))
            {
                Ingredient removedIngredient = ingredients.Where(i => i.Name == name).First();
                ingredients.Remove(removedIngredient);
                return true;
            }
            return false;
        }

//Method FindIngredient(string name) - returns an Ingredient with the given name.If it doesn't exist, return null.
public Ingredient FindIngredient(string name)
        {
            if (ingredients.Any(i => i.Name == name))
            {
                Ingredient foundIngredient = ingredients.Where(i => i.Name == name).First();
                return foundIngredient;
            }
            return null;
        }
//Method GetMostAlcoholicIngredient() – returns the Ingredient with most Alcohol.
public Ingredient GetMostAlcoholicIngredient()
        {
            return ingredients.OrderByDescending(i => i.Alcohol).First();
        }
//Getter CurrentAlcoholLevel – returns the amount of alcohol currently in the cocktail.
public int CurrentAlcoholLevel => ingredients.Sum(i => i.Alcohol);

//Method Report() - returns information about the Cocktail and the Ingredients inside it in the following format:
//"Cocktail: {name} - Current Alcohol Level: {CurrentAlcoholLevel}
//{ Ingredient1}
//{Ingredient2}
//… "
public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            foreach (var ingredient in ingredients)
            {
                sb.AppendLine(ingredient.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
