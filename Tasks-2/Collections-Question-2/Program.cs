internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan 20 adet sayı girmesi istenir.
        Console.WriteLine("Please, enter 20 numbers: ");
        int[] numbers = new int[20];
        int[] maxThreeNumbers = new int[3];
        int[] minThreeNumbers = new int[3];
        // Random rnd = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            //numbers[i] = rnd.Next(0, 100);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sayılar küçükten büyüğe sıralanır.
        Array.Sort(numbers);

        Console.WriteLine("All Numbers: ");
        foreach (var item in numbers)
            Console.Write(item + " ");

        // En küçük ilk üç sayı listenin ilk üç elemanı olacaktır. En büyük ilk üç sayı ise listenin son üç elemanı olacaktır.

        // İlk 3 eleman en küçük 3 eleman dizisine atandı ve toplamları alındı.

        int minTotal = 0;
        int maxTotal = 0;

        for (int j = 0; j < 3; j++)
        {
            minThreeNumbers[j] = numbers[j];
            minTotal += minThreeNumbers[j];
        }

        // Elemanlrı ters çevirerek ilk üç elemanı en büyük 3 eleman dizisine atandı ve toplamları alındı.

        Array.Reverse(numbers);

        for (int k = 0; k < 3; k++)
        {
            maxThreeNumbers[k] = numbers[k];
            maxTotal += maxThreeNumbers[k];
        }

        // En küçük 3 eleman ile en büyük üç eleman dizilerinin ortalamalaır alındı.

        double maxAverage = maxTotal / 3;
        double minAverage = minTotal / 3;
        double averageTotal = minAverage + maxAverage;

        Console.WriteLine("\nAverage of Max Three Numbers: " + maxAverage);
        Console.WriteLine("Average of Min Three Numbers: " + minAverage);
        Console.WriteLine("Average Total of Min/Max Three Numbers: " + averageTotal);

    }
}