internal class Task11
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan pozitif bir tam sayı girmesi istenir.
        Console.Write("Please, enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Girdiği tam sayı kadar pozitif tam sayı daha girmesi istenir.
        Console.WriteLine("Please, enter {0} more positive numbers: ", n);
        int[] numbers = new int[n];

        // Girilen tam sayılardan 2'ye bölünebilenler yazdırılır.
        for (int i = 0; i < n; i++)
        {
            int newNumber = Convert.ToInt32(Console.ReadLine());
            numbers[i] = newNumber;
        }
        for (int j = 0; j < n; j++)
        {
            if (numbers[j]%2 == 0)
            {
                Console.Write(numbers[j]+" ");
            }           
        }
    }
}