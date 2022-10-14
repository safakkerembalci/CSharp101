public class Focus : IAutomobile
{
    public Constants.Brands whichBrand()
    {
        return Constants.Brands.Ford;
    }

    public Constants.Colors whichColor()
    {
        return Constants.Colors.White;
    }

    public int numberWheels()
    {
        return 4;
    }
}