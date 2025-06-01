internal class Program
{
    private static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        var people = new Dictionary<string, int>();

        for (int i = 0; i < count; i++)
        {
            var pair = Console.ReadLine().Split(", ");

            var name = pair[0];
            var age = int.Parse(pair[1]);

            people.Add(name, age);
        }

        var condition = Console.ReadLine();
        var ageCondition = int.Parse(Console.ReadLine());
        var format = Console.ReadLine();

        Func<int, bool> conditionFunc;

        if (condition == "younger")
        {
            conditionFunc = age => age < ageCondition;
        }
        else
        {
            conditionFunc = age => age >= ageCondition;
        }

        var filteredPeople = Filter(people, conditionFunc);

        Func<string, int, string> selector;

        if (format == "name")
        {
            selector = (name, age) => name;
        }
        else if (format == "age")
        {
            selector = (name, age) => age.ToString();
        }
        else
        {
            selector = (name, age) => $"{name} - {age}";
        }

        foreach (var (name, age) in filteredPeople)
        {
            var result = selector(name, age);

            Console.WriteLine(result);
        }

            
        static Dictionary<string, int> Filter(
            Dictionary<string, int> dictionary, 
            Func<int, bool> predicate)
        {
            var result = new Dictionary<string, int>();

            foreach (var kvp in dictionary)
            {
                if (predicate(kvp.Value))
                {
                    result.Add(kvp.Key, kvp.Value);
                }
            }

            return result;
        }
    }
}