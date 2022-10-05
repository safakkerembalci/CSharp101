internal class Arrays
{
    private static void Main(string[] args)
    {
        // Dizi Tanımla
        string[] colors = new string[5];

        string[] animals = { "cat", "dog", "bird", "monkey" };

        int[] list;
        list = new int[5];

        // Dizilere Değer Atama ve Erişim
        colors[0] = "Blue";
        list[3] = 10;

        Console.WriteLine(animals[1]);
        Console.WriteLine(list[3]);
        Console.WriteLine(colors[0]);

        // Döngülerle dizi kullanımı

        Console.Write("Please, enter a number of elements: ");
        int arrayLenght = Convert.ToInt32(Console.ReadLine());

        int[] numberList = new int[arrayLenght];

        for (int i = 0; i < arrayLenght; i++)
        {
            Console.Write("Please enter {0}. number: ", i + 1);
            numberList[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = 0;

        foreach (var number in numberList)
        {
            total += number;
        }
        Console.WriteLine("Average: " + total / arrayLenght);
    }
}