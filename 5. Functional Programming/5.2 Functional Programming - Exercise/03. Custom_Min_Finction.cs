internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ',
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int min = Min(numbers);
        Console.WriteLine(min);
    }
    static int Min(int[] numbers)
    {
        Func<int, int, int> findMin = (element, min) => element < min ? element : min;
        return Aggregate(numbers, int.MaxValue, findMin);
    }
    static int Max(int[] numbers) => Aggregate(numbers, int.MinValue, Math.Max);

    static int Aggregate(int[] numbers, int initialValue, Func<int, int, int> aggregate)
    {
        if (numbers.Length == 0)
        {
            throw new InvalidOperationException("Cannot aggregate on an empty array.");
        }
        int accumulatedVal = initialValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            accumulatedVal = aggregate(numbers[i], accumulatedVal);
        }

        return accumulatedVal;
    }
}