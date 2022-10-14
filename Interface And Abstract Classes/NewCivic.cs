using static Constants;

public class NewCivic : Automobile
{
    public override Brands whichBrand()
    {
        return Brands.Honda;
    }

    public override Colors whichColor()
    {
        return Colors.Black;
    }
}