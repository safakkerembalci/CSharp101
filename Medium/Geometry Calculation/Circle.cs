class Circle
{
    // DAİRENİN ÖZELLİKLERİ TANIMLANDI
    private double radius;
    private double perimeter;
    private double area;
    private double pi = 3.14;

    // BOŞ BİR KURUCU METOT OLUŞTURULDU
    public Circle() { }

    // NORMAL KURUCU METOT OLUŞTURULDU
    public Circle(double radius, double pi)
    {
        this.Radius = radius;
        this.Pi = pi;
        this.Perimeter = 2 * pi * radius;
        this.Area = pi * radius * radius;
    }

    // ENCAPCULATION UYGULANDI
    public double Radius { get => radius; set => radius = value; }
    public double Perimeter { get => perimeter; set => perimeter = value; }
    public double Area { get => area; set => area = value; }
    public double Pi { get => pi; set => pi = value; }


    // ALAN HESABI İÇİN AYRI METOT YAZILDI
    internal void calcArea(double radius)
    {
        this.Area = this.Pi * radius * radius;
        Console.WriteLine("Dairenin Alanı: " + this.Area);
    }

    // ÇEVRE HESABI İÇİN AYRI METOT YAZILDI
    internal void calcPerimeter(double radius)
    {
        this.Perimeter = 2 * this.Pi * radius;
        Console.WriteLine("Dairenin Çevresi: " + this.Perimeter);
    }

    // İŞLEMLER İÇİN AŞAĞIDAKİ METOT YAZILDI
    internal void run()
    {
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: \n[1]-Çevre Hesaplama\n[2]-Alan Hesaplama");
            string select = Console.ReadLine()!;
            switch (select)
            {
                case "1":
                    Console.Write("Lütfen dairenin yarıçapını giriniz: ");
                    double radius = double.Parse(Console.ReadLine()!);
                    if (radius > 0)
                    {
                        calcPerimeter(radius);
                    }
                    else
                    {
                        Console.WriteLine("Negatif değer! Lütfen 0'dan büyük değer giriniz.");
                        run();
                    }
                    break;
                case "2":
                    Console.Write("Lütfen dairenin yarıçapını giriniz: ");
                    double radius1 = double.Parse(Console.ReadLine()!);
                    if (radius1 > 0)
                    {
                        calcArea(radius1);
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