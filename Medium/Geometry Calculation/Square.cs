internal class Square
{
    // KARENİN ÖZELLİKLERİ TANIMLANDI
    private double edge;
    private double area;
    private double perimeter;

    // BOŞ BİR KURUCU METOT OLUŞTURULDU
    public Square()
    {
    }

    // NORMAL KURUCU METOT OLUŞTURULDU
    public Square(double edge)
    {
        this.Edge = edge;
        this.Area = edge * edge;
        this.Perimeter = edge * 4;
    }

    // ENCAPCULATION UYGULANDI
    public double Edge { get => edge; set => edge = value; }
    public double Area { get => area; set => area = value; }
    public double Perimeter { get => perimeter; set => perimeter = value; }

    // ALAN HESABI İÇİN AYRI METOT YAZILDI
    internal void calcArea(double edge)
    {
        this.area = edge * edge;
        Console.WriteLine("Karenin Alanı: " + this.area);
    }

    // ÇEVRE HESABI İÇİN AYRI METOT YAZILDI
    internal void calcPerimeter(double edge)
    {
        this.perimeter = edge * 4;
        Console.WriteLine("Karenin Çevresi: " + this.perimeter);
    }

    // İŞLEMLER İÇİN AŞAĞIDAKİ METOT YAZILDI
    internal void run()
    {
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: \n[1]-Çevre Hesaplama\n[2]-Alan Hesaplama");
            string select = Console.ReadLine()!;
            switch (select)
            {
                case "1":
                    Console.Write("Lütfen karenin kenar uzunluğunu giriniz: ");
                    double edge = double.Parse(Console.ReadLine()!);
                    if (edge > 0)
                    {
                        calcPerimeter(edge);
                    }
                    else
                    {
                        Console.WriteLine("Negatif değer! Lütfen 0'dan büyük değer giriniz.");
                        run();
                    }
                    break;
                case "2":
                    Console.Write("Lütfen karenin kenar uzunluğunu giriniz: ");
                    double edge1 = double.Parse(Console.ReadLine()!);
                    if (edge1 > 0)
                    {
                        calcArea(edge1);
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