internal class Triangle
{
    // ÜÇGENİN ÖZELLİKLERİ TANIMLANDI
    private double firstEdge;
    private double secondEdge;
    private double baseEdge;
    private double height;
    private double area;
    private double perimeter;

    // BOŞ BİR KURUCU METOT OLUŞTURULDU
    public Triangle() { }

    // NORMAL KURUCU METOT OLUŞTURULDU
    public Triangle(int firstEdge, int secondEdge, int baseEdge, int height)
    {
        this.FirstEdge = firstEdge;
        this.SecondEdge = secondEdge;
        this.BaseEdge = baseEdge;
        this.Height = height;
        this.Area = (baseEdge * height) / 2;
        this.Perimeter = firstEdge + secondEdge + baseEdge;
    }

    // ENCAPCULATION UYGULANDI
    public double FirstEdge { get => firstEdge; set => firstEdge = value; }
    public double SecondEdge { get => secondEdge; set => secondEdge = value; }
    public double BaseEdge { get => baseEdge; set => baseEdge = value; }
    public double Height { get => height; set => height = value; }
    public double Area { get => area; set => area = value; }
    public double Perimeter { get => perimeter; set => perimeter = value; }

    // ALAN HESABI İÇİN AYRI METOT YAZILDI
    internal void calcArea(double baseEdge, double height)
    {
        this.area = (baseEdge * height) / 2;
        Console.WriteLine("Üçgenin Alanı: " + this.area);
    }

    // ÇEVRE HESABI İÇİN AYRI METOT YAZILDI
    internal void calcPerimeter(double firstEdge, double secondEdge, double baseEdge)
    {
        this.perimeter = (baseEdge + firstEdge + secondEdge);
        Console.WriteLine("Üçgenin Çevresi: " + this.perimeter);
    }

    // İŞLEMLER İÇİN AŞAĞIDAKİ METOT YAZILDI
    internal void run()
    {
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: \n[1]-Çevre Hesaplama\n[2]-Alan Hesaplama");
            string select = Console.ReadLine()!;
            switch (select)
            {
                case "1":
                    Console.WriteLine("Lütfen üçgenin kenar uzunluklarını giriniz: ");
                    double firstEdge = double.Parse(Console.ReadLine()!);
                    double secondEdge = double.Parse(Console.ReadLine()!);
                    double baseEdge = double.Parse(Console.ReadLine()!);
                    if (firstEdge > 0 && secondEdge > 0 && baseEdge > 0)
                    {
                        calcPerimeter(firstEdge, secondEdge, baseEdge);
                    }
                    else
                    {
                        Console.WriteLine("Negatif değer! Lütfen 0'dan büyük değer giriniz.");
                        run();
                    }
                    break;
                case "2":
                    Console.Write("Lütfen üçgenin yüksekliğini giriniz: ");
                    double height = double.Parse(Console.ReadLine()!);
                    Console.Write("Lütfen üçgenin taban kenarını giriniz: ");
                    double baseEdge1 = double.Parse(Console.ReadLine()!);
                    if (height > 0 && baseEdge1 > 0)
                    {
                        calcArea(baseEdge1, height);
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