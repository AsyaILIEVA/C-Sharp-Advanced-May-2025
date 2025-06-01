internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        PrintWhere(names, x => x.Length <= n);
    }

    static void PrintWhere(string[] names, Predicate<string> condition)
    {
        foreach (string name in names)
        {
            if (condition(name))
            {
                Console.WriteLine(name);
            }

        }
    }
}