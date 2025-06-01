internal class Program
{
    private static void Main(string[] args)
    {
        var people = Console.ReadLine().Split().ToList();

        var filters = new Dictionary<string, Predicate<string>>();

        string[] command = Console.ReadLine().Split(";");

        while (command[0] != "Print")
        {
            if (command[0] == "Add filter")
            {
                filters.Add(command[1] + command[2], GetPredicate(command[1], command[2]));
            }

            if (command[0] == "Remove filter")
            {
                filters.Remove(command[1] + command[2]);
            }
            command = Console.ReadLine().Split(";");
        }

        foreach (var filter in filters)
        {
            people.RemoveAll(filter.Value);
        }

        Console.WriteLine(String.Join(" ", people));
    }
    public static Predicate<string> GetPredicate(string filter, string value)
    {
        switch (filter)
        {
            case "Starts with":
                return s => s.StartsWith(value);
            case "Ends with":
                return s => s.EndsWith(value);
            case "Contains":
                return s => s.Contains(value);
            case "Length":
                return s => s.Length == int.Parse(value);

            default:
                return default(Predicate<string>);
        }
    }
}

