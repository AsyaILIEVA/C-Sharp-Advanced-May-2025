internal class Program
{
    private static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int n = sizes[0], m = sizes[1];

        HashSet<int> first = ReadNumbers(n), second = ReadNumbers(m);
        foreach (int num in first)
        {
            if (second.Contains(num))
            {
                Console.Write($"{num} ");
            }
        }

    }

    static HashSet<int> ReadNumbers(int count)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < count; i++)
        {
            int current = int.Parse(Console.ReadLine());
            set.Add(current);
        }
        return set;
    }
}