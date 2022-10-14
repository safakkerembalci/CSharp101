public class AbstractClasses
{
    public static void Main(string[] args)
    {
        Focus focus = new Focus();
        Console.WriteLine(focus.whichBrand().ToString());
        Console.WriteLine(focus.whichColor().ToString());
        Console.WriteLine(focus.numberWheels().ToString());

        Console.WriteLine("*******************************");

        Civic civic = new Civic();
        Console.WriteLine(civic.whichBrand().ToString());
        Console.WriteLine(civic.whichColor().ToString());
        Console.WriteLine(civic.numberWheels().ToString());

        Console.WriteLine("*******************************");

        Corolla corolla = new Corolla();
        Console.WriteLine(corolla.whichBrand().ToString());
        Console.WriteLine(corolla.whichColor().ToString());
        Console.WriteLine(corolla.numberWheels().ToString());

        Console.WriteLine("*******************************");

        NewFocus focus1 = new NewFocus();
        Console.WriteLine(focus1.whichBrand().ToString());
        Console.WriteLine(focus1.whichColor().ToString());
        Console.WriteLine(focus1.numberWheels().ToString());

        Console.WriteLine("*******************************");

        NewCivic civic1 = new NewCivic();
        Console.WriteLine(civic1.whichBrand().ToString());
        Console.WriteLine(civic1.whichColor().ToString());
        Console.WriteLine(civic1.numberWheels().ToString());

    }
}