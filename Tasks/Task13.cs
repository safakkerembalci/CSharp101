internal class Task13
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan pozitif bir tam sayı girmesi istenir. Negatif değer girmesi halinde uyarı verilir.

        Console.Write("Please, enter a positive number: ");
        int i = 0;
        int n = 0;
        while (n<1)
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
               Console.WriteLine("!!!This number is not a positive, try again please!!!");
            }
            i++;          
        }

        // Girilen pozitif tam sayı kadar kelime girmesi istenir.

        Console.WriteLine("Please, enter {0} words: ", n);

        string [] words = new string[n];

        for (int j = 0; j < n; j++)
        {
            words[j] = Console.ReadLine()!;
        }

        // Girilen kelimeler ters sırada yazdırılır.

        Console.WriteLine("----------");

        Array.Reverse(words);
        foreach (var k in words)
        {
            Console.WriteLine(k);
        }
    }
}