using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace Guild
{
    public class Guild
    {
        //Next, write a C# class Guild that has a roster (a collection that stores the entity Player). All entities inside the repository have the same properties. Also, the Guild class should have those properties:
        //Name: string
        //Capacity: int
        private List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        //The class constructor should receive name and capacity, also it should initialize the roster with a new instance of the collection.
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            roster = new List<Player>();
        }
        //Implement the following features:        
        //Field roster - a collection that holds added players

        //Method AddPlayer(Player player) - adds an entity to the roster if there is room for it
        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }
        //Method RemovePlayer(string name) - removes a player by given name, if such exists, and returns bool
        public bool RemovePlayer(string name)
        {
            if (roster.Any(r => r.Name == name))
            {
                Player removedPlayer = roster.Where(r => r.Name == name).First();
                roster.Remove(removedPlayer);
                return true;
            }
            return false;            
        }
        //Method PromotePlayer(string name) - promote (set his rank to "Member") the first player with the given name.If the player is already a "Member", do nothing.
        public void PromotePlayer(string name)
        {
            Player promotedPlayer = roster.FirstOrDefault(p => p.Name == name);            

            if (promotedPlayer != null && promotedPlayer.Rank != "Member")
            {
                promotedPlayer.Rank = "Member";
            }
        }
        //Method DemotePlayer(string name)- demote(set his rank to "Trial") the first player with the given name.If the player is already a "Trial",  do nothing.
        public void DemotePlayer(string name)
        {
            Player demotedPlayer = roster.FirstOrDefault(p => p.Name == name);

            if (demotedPlayer != null && demotedPlayer.Rank != "Trial")
            {
                demotedPlayer.Rank = "Trial";
            }
        }

        //Method KickPlayersByClass(string class) - removes all the players by the given class and returns all players from that class as an array
        public Player[] KickPlayersByClass(string class1)
        {
            Player[] players = this.roster
                .Where(p => p.Class == class1)
                .ToArray();

            this.roster.RemoveAll(p => p.Class == class1);

            return players;
        }
        //Getter Count - returns the number of players
        public int Count => roster.Count;

        //Report() - returns a string in the following format:	
        //"Players in the guild: {guildName}
        //{Player1}
        //{Player2}
        //(…)"
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");

            foreach (Player player in roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
