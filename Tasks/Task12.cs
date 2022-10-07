internal class Task12
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan 2 adet pozitif tam sayı (n,m) girmesi istenir.
        Console.WriteLine("Please, enter two positive numbers: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        // İlk girilen sayı (n) kadar daha pozitif tam sayı girmesi istenir.
        Console.WriteLine("Please, enter {0} positive numbers: ", n);
        int [] numbers = new int[n];

        // Girilen tam sayılar, 2. girilen (m) tam sayıya eşit olması ya da tam bölünebilmesi durumunda konsola yazıdırılır.
        for (int i = 0; i < n; i++)
        {
            int newNumber = Convert.ToInt32(Console.ReadLine());
            numbers[i] = newNumber;
        }
        for (int j = 0; j < n; j++)
        {
            if (numbers[j] == m || numbers[j] % m == 0)
            {
                Console.Write(numbers[j]+" ");
            }
        }
    }
}