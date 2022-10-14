public class Civic : IAutomobile
{
    public Constants.Brands whichBrand()
    {
        return Constants.Brands.Honda;
    }

    public Constants.Colors whichColor()
    {
        return Constants.Colors.Black;
    }

    public int numberWheels()
    {
        return 4;
    }

}