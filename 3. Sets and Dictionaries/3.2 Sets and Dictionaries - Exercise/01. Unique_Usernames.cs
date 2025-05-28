internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //HashSet<string> usernames = new HashSet<string>();
        HashSet<string> usernames = [];


        for (int i = 0; i < n; i++)
        {
            string current = Console.ReadLine();
            usernames.Add(current);
        }

        foreach (string username in usernames)
        {
            Console.WriteLine(username);
        }
    }
}