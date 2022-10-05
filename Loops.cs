internal class Loops
{
    private static void Main(string[] args)
    {
        // Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.

        Console.Write("Enter a number: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = 1; i <= counter; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }

        // 1 ile 1000 arasındaki tek ve çift sayıların kendi içerisindeki toplamlarını yazdırma

        int oddTotal = 0;
        int evenTotal = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 1)
            {
                oddTotal += i; // oddTotal = oddTotal + i;
            }
            else
            {
                evenTotal += i; // evenTotal = evenTotal + i;
            }
        }
        Console.WriteLine("Odd Total: " + oddTotal);
        Console.WriteLine("Even Total: " + evenTotal);

        // break, continue

        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
            {
                break; // Döngüyü 4 e gelince sonlandırır.
            }
            Console.WriteLine(i);
        }

        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
            {
                continue; // Döngüyü sonuna kadar devam etmesini sağlar.
            }
            Console.WriteLine(i);
        }
    }
}