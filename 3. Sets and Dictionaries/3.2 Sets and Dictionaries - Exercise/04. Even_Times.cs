internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //key: number -> value: occurrences
        Dictionary<int, int> counter = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (!counter.ContainsKey(number)) counter[number] = 0;
            counter[number]++;            
        }

        int result = counter.Single(x => x.Value % 2 == 0).Key;
        Console.WriteLine(result);

    }
}