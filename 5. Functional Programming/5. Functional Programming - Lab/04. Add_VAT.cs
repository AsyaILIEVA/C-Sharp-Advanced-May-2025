internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadLine()
            .Split(", ")
            .Select(double.Parse)
            .Select(n => n * 1.2)
            .Select(n => $"{n:F2}")
            .ToList()
            .ForEach(n => Console.WriteLine(n));

        //Console.ReadLine()
        //    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        //    .Select(double.Parse)
        //    .Select(n => n * 1.2)
        //    .ToList()
        //    .ForEach(n => Console.WriteLine($"{n:f2}")); // Ctrl + /
    }
}