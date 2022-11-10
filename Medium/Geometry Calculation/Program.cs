string select;

while (true)
{
    Console.WriteLine("İşlem yapmak istediğiniz geometrik şekli seçiniz: \n[1]-Daire\n[2]-Üçgen\n[3]-Kare\n[4]-Dikdörtgen\n[0]-Çıkış");

    select = Console.ReadLine()!;

    switch (select)
    {
        case "0":
            Methods.exit();
            continue;
        case "1":
            Circle circle = new Circle();
            circle.run();
            continue;
        case "2":
            Triangle triangle = new Triangle();
            triangle.run();
            continue;
        case "3":
            Square square = new Square();
            square.run();
            continue;
        case "4":
            Rectangle rectangle = new Rectangle();
            rectangle.run();
            continue;
        default:
            Console.WriteLine("Lütfen 1-4 arasında bir değer giriniz.");
            continue;
    }
}
