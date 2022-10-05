internal class ArrayClass
{
    private static void Main(string[] args)
    {
        // Sort (Sıralama İşlemi)
        int [] list = {23, 12, 4, 86 ,72, 3, 11, 17};

        Console.WriteLine("***** Unsorted Array ******");
        foreach (var i in list)
        {
            Console.WriteLine(i);
        } 

        Console.WriteLine("***** Sorted Array ******");
        Array.Sort(list);
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }

        // Clear (İstediğin dizindeki ve adette elemana 0 atar.)
        Console.WriteLine("***** Clear Array ******");

        Array.Clear(list,2,2);
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }

        // Reverse (Diziyi tersine çevirir.)
        Console.WriteLine("***** Reverse Array ******");
        Array.Reverse(list);
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }

        // IndexOf (Sorulan elemanın indeks numarasını döner.)
        Console.WriteLine("***** IndexOf Array ******");
        Console.WriteLine(Array.IndexOf(list,23));

        // Resize
        Console.WriteLine("***** Resize Array ******");
        Array.Resize<int>(ref list,9);
        list[8] = 99;
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
    }
}