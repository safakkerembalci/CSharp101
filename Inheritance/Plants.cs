public class Plants : LivingThings
{
    protected void Photosynthesis()
    {
        Console.WriteLine("Plants perform photosynthesis!");
    }
}

public class PlantsWithSeeds : Plants
{
    public PlantsWithSeeds()
    {
        base.Photosynthesis();
        base.Nutrition();
        base.Excretion();
        base.Respiratory();
    }
    public void PropagationBySeed()
    {
        Console.WriteLine("Seed plants reproduce by seeds!");
    }
}

public class PlantsWithoutSeeds : Plants
{
    public PlantsWithoutSeeds()
    {
        base.Photosynthesis();
        base.Nutrition();
        base.Excretion();
        base.Respiratory();
    }

    public void Sporulation()
    {
        Console.WriteLine("Seedless plants reproduce by spores!");
    }
}