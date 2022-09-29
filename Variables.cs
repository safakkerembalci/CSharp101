internal class Variables
{
    private static void Main(string[] args)
    {
        // Ekrana bastırma
        Console.WriteLine("Hello World");

        // Klavyeden giriş yapma
        Console.Write("Enter your name please: ");
        string n = Console.ReadLine();

        // Klavyeden girilen veriyi ekrana bastırma
        Console.WriteLine("Welcome "+n);

        // Değişkenleri tanımlama ve ekrana bastırma
        byte a = 1;
        Console.WriteLine(a);
        sbyte b = 2;
        Console.WriteLine(b);
        short c = 14;
        Console.WriteLine(c);
        ushort d = 12;
        Console.WriteLine(d);
        int i = 1548;
        Console.WriteLine(i);
        long l = 8;
        Console.WriteLine(l);
        float f = 25.5f;
        Console.WriteLine(f);
        double e = 84.5;
        Console.WriteLine(e);
        string str = "Şafak Kerem Balcı";
        Console.WriteLine(str);
        bool b1 = true;
        Console.WriteLine(b1);
        bool b2 = false;
        Console.WriteLine(b2);

        // Datetime kullanımı
        DateTime dt = DateTime.Now;
        Console.WriteLine("Date Now: "+dt);

        // Object kullanımı (üst değişken türü)
        object o1 = "x";
        Console.WriteLine(o1);
        object o2 = 'y';
        Console.WriteLine(o2);
        object o3 = 4;
        Console.WriteLine(o3);
        object o4 = 4.3;
        Console.WriteLine(o4);

        // String ifadeler
        string str1 = "";
        Console.WriteLine(str1);
        string str2 = null;
        Console.WriteLine(str2);
        string str3 = string.Empty;
        Console.WriteLine(str3);
        string name = "Şafak Kerem";
        string surname = "Balcı";
        string fullName = name + " " + surname;
        Console.WriteLine(fullName);

        // Integer tanımlama şekilleri
        int int1 = 5;
        int int2 = 3;
        int int3 = int1 * int2;
        Console.WriteLine(int3);

        // Boolean
        bool bool1 = 10<2;
        Console.WriteLine(bool1);

        // Değişken dönüşümleri
        string str4 = "20";
        int int4 = 20;
        string newValue = str4 + int4.ToString();
        Console.WriteLine(newValue); // Çıktısı 2020

        int int5 = int4 + Convert.ToInt32(str4);
        Console.WriteLine(int5); // Çıktısı 40

        int int6 = int4 + int.Parse(str4);
        Console.WriteLine(int6); // Çıktısı 40

        // Datetime
        string dateTime = DateTime.Now.ToString("dd.mm.yyyy");
        Console.WriteLine(dateTime);
        string dateTime2 = DateTime.Now.ToString("dd/mm/yyyy");
        Console.WriteLine(dateTime2);

        // Hour
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);

    }
}