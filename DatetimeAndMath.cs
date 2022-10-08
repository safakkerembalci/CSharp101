internal class DatetimeAndMath
{
    private static void Main(string[] args)
    {
        // DateTime (Tarih ve zamanı getirir.)
        Console.WriteLine(DateTime.Now); 
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());

        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        // DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));

        Console.WriteLine(DateTime.Now.ToString("MM"));
        Console.WriteLine(DateTime.Now.ToString("MMM"));
        Console.WriteLine(DateTime.Now.ToString("MMMM"));

        Console.WriteLine(DateTime.Now.ToString("yy"));
        Console.WriteLine(DateTime.Now.ToString("yyy"));

        // Math Methods

        // Mutlak Değer
        Console.WriteLine(Math.Abs(-25)); // Sayının mutlak değerini verir.

        // Trigonometri
        Console.WriteLine(Math.Sin(10));
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));

        // Yuvarlama İşlemleri
        Console.WriteLine(Math.Ceiling(22.3)); // Sayıyı her zaman bir üst tam sayıya yuvarlar.
        Console.WriteLine(Math.Floor(22.7)); // Sayıyı her zaman bir alt tam sayıya yuvarlar.
        Console.WriteLine(Math.Round(22.3)); // Sayıyı en yakın olan tam sayıya yuvarlar.
        Console.WriteLine(Math.Round(22.7)); // Sayıyı en yakın olan tam sayıya yuvarlar.

        // Min Max İşlemleri
        Console.WriteLine(Math.Max(2,6)); // İki sayı arasından maksimum olanı verir.
        Console.WriteLine(Math.Min(2,6)); // İki sayı arasından minimum olanı verir

        // Üs İşlemleri
        Console.WriteLine(Math.Pow(3,4)); // Bir sayının üssünü döndürür.
        Console.WriteLine(Math.Exp(3)); // e üzeri sayı sonucunu döndürür.

        // Karakök
        Console.WriteLine(Math.Sqrt(9)); // Sayının karakökünü verir.
        
        // Logoritma
        Console.WriteLine(Math.Log(9)); // Sayının e tabanındaki değerini verir.
        Console.WriteLine(Math.Log10(10)); // Sayının 10 tabanındaki değerini verir.

    }
}