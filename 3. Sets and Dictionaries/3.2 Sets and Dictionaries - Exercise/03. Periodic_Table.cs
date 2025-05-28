internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> set = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            string[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string element in elements) 
            {
                set.Add(element);            
            }
        }
        Console.WriteLine(string.Join(" ", set.OrderBy(x => x)));
    }
}