internal class Rectangle
{

    // DİKDÖRTGENİN ÖZELLİKLERİ TANIMLANDI
    private double shortEdge;
    private double longEdge;
    private double perimeter;
    private double area;

    // BOŞ BİR KURUCU METOT OLUŞTURULDU
    public Rectangle()
    {
    }

    // NORMAL KURUCU METOT OLUŞTURULDU
    public Rectangle(int longEdge, int shortEdge)
    {
        this.LongEdge = longEdge;
        this.ShortEdge = shortEdge;
        this.Area = longEdge * shortEdge;
        this.Perimeter = 2 * (longEdge + shortEdge);
    }

    // ENCAPCULATION UYGULANDI
    public double ShortEdge { get => shortEdge; set => shortEdge = value; }
    public double LongEdge { get => longEdge; set => longEdge = value; }
    public double Perimeter { get => perimeter; set => perimeter = value; }
    public double Area { get => area; set => area = value; }

    // ALAN HESABI İÇİN AYRI METOT YAZILDI
    internal void calcArea(double longEdge, double shortEdge)
    {
        this.Area = shortEdge * longEdge;
        Console.WriteLine("Dikdörtgenin Alanı: " + this.Area);
    }

    // ÇEVRE HESABI İÇİN AYRI METOT YAZILDI
    internal void calcPerimeter(double longEdge, double shortEdge)
    {
        this.Perimeter = 2 * (shortEdge + longEdge);
        Console.WriteLine("Dikdörtgenin Çevresi: " + this.Perimeter);
    }

    // İŞLEMLER İÇİN AŞAĞIDAKİ METOT YAZILDI
    internal void run()
    {
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: \n[1]-Çevre Hesaplama\n[2]-Alan Hesaplama");
            string select = Console.ReadLine()!;
            switch (select)
            {
                case "1":
                    Console.Write("Lütfen dikdörtgenin uzun kenar uzunluğunu giriniz: ");
                    double longEdge = double.Parse(Console.ReadLine()!);
                    Console.Write("Lütfen dikdörtgenin kısa kenar uzunluğunu giriniz: ");
                    double shortEdge = double.Parse(Console.ReadLine()!);
                    if (shortEdge > 0 && longEdge > 0)
                    {
                        calcPerimeter(longEdge, shortEdge);
                    }
                    else
                    {
                        Console.WriteLine("Negatif değer! Lütfen 0'dan büyük değer giriniz.");
                        run();
                    }
                    break;
                case "2":
                    Console.Write("Lütfen dikdörtgenin uzun kenar uzunluğunu giriniz: ");
                    double longEdge1 = double.Parse(Console.ReadLine()!);
                    Console.Write("Lütfen dikdörtgenin kısa kenar uzunluğunu giriniz: ");
                    double shortEdge1 = double.Parse(Console.ReadLine()!);
                    if (shortEdge1 > 0 && longEdge1 > 0)
                    {
                        calcArea(longEdge1, shortEdge1);
                    }
                    else
                    {
                        Console.WriteLine("Negatif değer! Lütfen 0'dan büyük değer giriniz.");
                        run();
                    }
                    break;
                default:
                    Console.WriteLine("Lütfen 1-2 arasında bir değer giriniz.");
                    break;
            }
    }
}