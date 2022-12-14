internal class Dictionaries
{
    private static void Main(string[] args)
    {
        // System.Collections.Generic
        Dictionary<int,string> users = new Dictionary<int, string>();

        users.Add(10,"Ayşe Yılmaz");
        users.Add(12, "Ahmet Yılmaz");
        users.Add(18, "Deniz Arda");
        users.Add(20, "Özcan Coşar");

        // Print
        Console.WriteLine("***** Print *****");

        Console.WriteLine(users[12]);

        foreach (var item in users)
        {
            Console.WriteLine(item);
        }

        // Count
        Console.WriteLine(users.Count());

        // Contains
        Console.WriteLine(users.ContainsKey(12));
        Console.WriteLine(users.ContainsValue("Şafak Kerem Balcı"));

        // Remove
        users.Remove(12);
        foreach (var item in users)
        {
            Console.WriteLine(item);
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

        // Keys - Values
        foreach (var item in users.Keys)
        {
            Console.WriteLine(item);
        }
        foreach (var item in users.Values)
        {
            Console.WriteLine(item);
        }

    }
}