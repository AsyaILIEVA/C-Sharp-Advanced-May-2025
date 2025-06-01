internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ',
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        int[] filtered = FilterInReverse(numbers, x => x % n != 0);
        Console.WriteLine(string.Join(' ', filtered));
    }

    static int[] FilterInReverse(int[] numbers, Predicate<int> condition)
    {
        List<int> result = new List<int>();

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (condition(numbers[i]))
            {
                result.Add(numbers[i]);
            }
        }

        return result.ToArray();
    }
}