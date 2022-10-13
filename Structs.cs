class Structs
{
    static void Main(string[] args)
    {
       Rectangle rectangle = new Rectangle();
       rectangle.shortEdge = 3;
       rectangle.longEdge = 4;
       Console.WriteLine("Class Area: {0}", rectangle.calcArea());

       RectangleStruct rectangle1 = new RectangleStruct(); // Nesne oluşturmak için bu şekilde kısa yolu bulunmaktadır.

       //rectangle1.shortEdge = 3;
       //rectangle1.longEdge = 4;
       Console.WriteLine("Struct Area: {0}", rectangle1.calcArea());

    }
}

class Rectangle
{
    public int shortEdge;
    public int longEdge;
    public Rectangle()
    {
        shortEdge = 3;
        longEdge = 4;
    }
    public long calcArea()
    {
        return this.shortEdge * this.longEdge;
    }
}

struct RectangleStruct
{
    public int shortEdge;
    public int longEdge;
    public RectangleStruct()
    {
        shortEdge = 3;
        longEdge = 4;
    }
    public long calcArea()
    {
        return this.shortEdge * this.longEdge;
    }
}