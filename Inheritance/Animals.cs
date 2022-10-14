public class Animals : LivingThings
{
    protected void Adaptation()
    {
        Console.WriteLine("Animals adapt!");
    }
}

public class Reptiles : Animals
{
    public Reptiles()

    {
        base.Adaptation();
        base.Nutrition();
        base.Excretion();
        base.Respiratory();
    }
    public void MoveByCrawling()
    {
        Console.WriteLine("Reptiles move by crawling!");
    }
}

public class Birds : Animals
{
    public Birds()
    {
        base.Adaptation();
        base.Nutrition();
        base.Excretion();
        base.Respiratory();
    }
    public void Flying()
    {
        Console.WriteLine("Birds fly!");
    }
}