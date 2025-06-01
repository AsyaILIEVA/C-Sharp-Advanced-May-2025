internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] dividers = Console.ReadLine().Split(' ',
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Predicate<int>[] conditions = new Predicate<int>[dividers.Length];

        for (int i = 0; i < dividers.Length; i++)
        {
            int divider = dividers[i];
            conditions[i] = (x) => x % divider == 0;
        }

        int[] result = FilterInRange(1, n, conditions);
        Console.WriteLine(string.Join(' ', result));


    }

    static int[] FilterInRange(int start, int end, Predicate<int>[] conditions)
    {
        List<int> result = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (MatchesAll(i, conditions))
                result.Add(i);
        }
        return result.ToArray();
    }

    static bool MatchesAll(int value, Predicate<int>[] conditions)
    {
        foreach (Predicate<int> condition in conditions)
        {
            if (!condition(value)) return false;
        }
        return true;
    }
}