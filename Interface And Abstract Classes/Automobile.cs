using static Constants;

public abstract class Automobile
{
    public int numberWheels()
    {
        return 4;
    }

    public virtual Colors whichColor()
    {
        return Colors.White;
    }

    public abstract Brands whichBrand();
    
}