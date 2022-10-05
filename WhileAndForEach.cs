internal class WhileAndForEach
{
    private static void Main(string[] args)
    {
        // While
        // 1'den başlayarak konsoldan girilen sayıya kadar tüm sayıların ortalamasını yazdırma

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int i = 1;
        int total = 0;
        while (i <= number)
        {
            total += i;
            i++;
        }
        Console.WriteLine(total / number);

        // a'dan z'ye kadar tüm harfleri konsola yazdırma

        char character = 'a';
        while (character <= 'z')
        {
            Console.Write(character + " ");
            character++;
        }

        // ForEach

        string[] cars = { "BMW", "Ford", "Toyota", "Nissan" };

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}