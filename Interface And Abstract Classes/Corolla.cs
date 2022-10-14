public class Corolla : IAutomobile
{
    public Constants.Brands whichBrand()
    {
        return Constants.Brands.Toyota;
    }

    public Constants.Colors whichColor()
    {
        return Constants.Colors.Grey;
    }

    public int numberWheels()
    {
        return 4;
    }
}