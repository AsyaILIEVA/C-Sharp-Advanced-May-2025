internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Action<List<string>, int>> mutationHandlers = new Dictionary<string, Action<List<string>, int>>
        {
            ["Remove"] = (list, index) => list.RemoveAt(index),
            ["Double"] = (list, index) => list.Insert(index + 1, list[index])
        };
        Dictionary<string, Func<string, Func<string, bool>>> conditionHandlers = new Dictionary<string, Func<string, Func<string, bool>>>
        {
            ["StartsWith"] = (param) =>
            {
                return (val) => val.StartsWith(param);
            },

            ["EndsWith"] = (param) =>
            {
                return (val) => val.EndsWith(param);
            },

            ["Length"] = (param) =>
            {
                int length = int.Parse(param);
                return (val) => val.Length == length;
            }
        };

        List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string action = data[0], conditionName = data[1], param = data[2];

            Func<string, Func<string, bool>> conditionBuilder = conditionHandlers[conditionName];
            Func<string, bool> condition = conditionBuilder(param);
            Action<List<string>, int> mutator = mutationHandlers[action];
            ExecuteCommand(guests, condition, mutator);
        }

        if (guests.Count == 0) Console.WriteLine("Nobody is going to the party!");
        else Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
    }

    private static void ExecuteCommand(List<string> guests, Func<string, bool> condition, Action<List<string>, int> mutator)
    {
        for (int i = guests.Count - 1; i >= 0; i--)
        {
            if (condition(guests[i]))
                mutator(guests, i);
        }
    }
}
    
