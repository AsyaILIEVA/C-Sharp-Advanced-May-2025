internal class Program
{
    private static void Main(string[] args)
    {
        Action<string> print = (x) => Console.WriteLine($"Sir {x}");

        string[] names = Console.ReadLine().Split(' ',
            StringSplitOptions.RemoveEmptyEntries);
        ForEach(names, print);
    }

    static void ForEach(string[] names, Action<string> print)
    {
        foreach (string name in names)
        {
            print(name);
        }
    }
}
