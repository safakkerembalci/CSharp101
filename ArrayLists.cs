using System.Collections;

internal class ArrayLists
{
    private static void Main(string[] args)
    {
        // System.Collections namespace
        ArrayList list = new ArrayList();
        ArrayList list2 = new ArrayList();

        list.Add("Ayşe");
        list.Add(2);
        list.Add(true);
        list.Add('Q');

        // Print
        Console.WriteLine(list[1]);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // AddRange
        Console.WriteLine("***** AddRange *****");
        string[] colors = {"red", "yellow", "green"};
        List<int> numbers = new List<int>{1,8,3,7,9,92,5};
        list.AddRange(colors);
        list.AddRange(numbers);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Sort
        Console.WriteLine("***** Sort *****");

        List<int> numbers2 = new List<int>{1,8,3,7,9,92,5};

        list2.AddRange(numbers2);

        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }

        list2.Sort();

        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }

        // Binary Search
        Console.WriteLine("***** Binary Search *****");
        Console.WriteLine(list2.BinarySearch(92));

        // Reverse
        Console.WriteLine("****** Reverse *****");
        list2.Reverse();

        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }

        // Clear
        list.Clear();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        
    }
}