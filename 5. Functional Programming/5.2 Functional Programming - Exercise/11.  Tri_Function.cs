internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        var names = Console.ReadLine().Split().ToArray();

        Func<string, int, bool> checkName = (name, sum) => name.Sum(c => c) >= sum;

        Func<string[], int, Func<string, int, bool>, string> getName = (names, sum, firstName) =>
        names.FirstOrDefault(name => firstName(name, sum));

        Console.WriteLine(getName(names, number, checkName));
    }
}