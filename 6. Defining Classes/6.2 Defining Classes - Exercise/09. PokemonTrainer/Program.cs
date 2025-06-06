namespace PokemonTrainer;
public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string trainerName = data[0], pokemonName = data[1], pokemonElement = data[2];
            int pokemonHealth = int.Parse(data[3]);

            if (!trainers.ContainsKey(trainerName))
                trainers[trainerName] = new Trainer { Name = trainerName, Pokemons = new List<Pokemon>() };

            Pokemon pokemon = new Pokemon { Name = pokemonName, Element = pokemonElement, Health = pokemonHealth };

            trainers[trainerName].Pokemons.Add(pokemon);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (Trainer trainer in trainers.Values)
                    ProcessCommand(input, trainer);
        }
            foreach(Trainer trainer in trainers.Values.OrderByDescending(t => t.Badges))
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
    }

        static void ProcessCommand(string command, Trainer trainer)
        {
            if (trainer.Pokemons.Any(p => p.Element == command))
                trainer.Badges++;
            else
            {
                for (int i = trainer.Pokemons.Count - 1; i >= 0; i--)
                {
                    trainer.Pokemons[i].Health -= 10;
                    if (trainer.Pokemons[i].Health <= 0)
                        trainer.Pokemons.RemoveAt(i);                    
                }
            }
        }
    }
