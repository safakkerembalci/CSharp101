class Inheritance
{
    static void Main(string[] args)
    {
        // Canlılar
        // Bitkiler - Hayvanlar
        // Tohumlu - Tohumsuz / Sürüngenler - Kuşlar

        PlantsWithSeeds plant1 = new PlantsWithSeeds();
        plant1.PropagationBySeed();

        Console.WriteLine("*******************");

        Birds bird1 = new Birds();

        bird1.Flying();

    }
}