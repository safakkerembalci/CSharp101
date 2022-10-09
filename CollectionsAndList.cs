internal class CollectionsAndList
{
    private static void Main(string[] args)
    {
        // List<T> class
        // System.Collections.Generic
        // T -> Object türündedir.

        List<int> numberList = new List<int>();

        numberList.Add(23);
        numberList.Add(10);
        numberList.Add(4);
        numberList.Add(5);
        numberList.Add(92);
        numberList.Add(34);

        List<string> colorList = new List<string>();

        colorList.Add("red");
        colorList.Add("blue");
        colorList.Add("orange");
        colorList.Add("yellow");
        colorList.Add("green");

        // Count
        Console.WriteLine(colorList.Count);
        Console.WriteLine(numberList.Count);

        // ForEach

        foreach (var item in numberList)
        {
            Console.WriteLine(item);
        }

        foreach (var item in colorList)
        {
            Console.WriteLine(item);
        }

        numberList.ForEach(item => Console.WriteLine(item));
        colorList.ForEach(item => Console.WriteLine(item));

        // Remove
        numberList.Remove(4);
        colorList.Remove("green");

        numberList.ForEach(item => Console.WriteLine(item));
        colorList.ForEach(item => Console.WriteLine(item));

        // RemoveAt

        numberList.RemoveAt(0);
        colorList.RemoveAt(1);

        numberList.ForEach(item => Console.WriteLine(item));
        colorList.ForEach(item => Console.WriteLine(item));

        // Contains

        if (numberList.Contains(10))
        {
            Console.WriteLine("10 has been founded in the list!");
        }

        // BinarySearch

        Console.WriteLine(colorList.BinarySearch("yellow"));

        // Array => List
        string[] animals = { "cat", "dog", "bird" };
        List<string> animalList = new List<string>(animals);

        foreach (var item in animalList)
        {
            Console.WriteLine(item);
        }

        // Clear

        animalList.Clear();

        // Object in the List

        List<Users> usersList = new List<Users>();
        Users user1 = new Users();
        user1.Name = "Ayşe";
        user1.Surname = "Yılmaz";
        user1.Age = 26;

        Users user2 = new Users();
        user2.Name = "Özcan";
        user2.Surname = "Çalışkan";
        user2.Age = 24;

        usersList.Add(user1);
        usersList.Add(user2);

        List<Users> newList = new List<Users>();

        newList.Add(new Users()
        {
            Name = "Deniz",
            Surname = "Arda",
            Age = 18
        });

        foreach (var user in usersList)
        {
            Console.WriteLine("User Name: " + user.Name);
            Console.WriteLine("User Surname: " + user.Surname);
            Console.WriteLine("User Age: " + user.Age);
        }

        newList.Clear();
    }

    public class Users
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}