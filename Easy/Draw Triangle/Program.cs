class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a dimension: ");
        int dimension = int.Parse(Console.ReadLine()!);
        Console.Write("Enter a dimension: ");
        int dimension2 = int.Parse(Console.ReadLine()!);
        rightTriangle(dimension);
        triangle(dimension2);
        
    }
    public static void rightTriangle(int value)
    {
        for (int i = 0; i <= value; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void triangle(int value)
    {
        for (int i = 1; i <= value; i++)
        {
            for (int j = 0; j < value - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}