internal class Methods
{
    internal static void exit()
    {
        string confirm;
        Console.WriteLine("Çıkmak İstediğinizden Emin misiniz? (E/H)");
        confirm = Console.ReadLine()!.ToUpper();
        if (confirm == "E")
        {
            Console.WriteLine("Tekrar bekleriz...");
            Environment.Exit(0);
        }
    }
}