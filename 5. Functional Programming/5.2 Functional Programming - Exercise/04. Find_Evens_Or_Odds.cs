internal class Program
{
    private static void Main(string[] args)
    {
        int[] range = Console.ReadLine().Split(' ', 
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int start = range[0], end = range[1];
        string parity = Console.ReadLine();

        Predicate<int> condition;
        if (parity == "even") condition = (x) => x % 2 == 0;
        else if (parity == "odd") condition = (x) => x % 2 != 0;
        else throw new InvalidOperationException("Invalid parity");

        int[] result = FilterRange(start, end, condition);
        Console.WriteLine(string.Join(' ', result));
    }

    static int[] FilterRange(int start, int end, Predicate<int> condition)
    {
        List<int> result = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (condition(i))
                result.Add(i);
        }             
            
        
        return result.ToArray();
    }
}
