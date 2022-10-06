internal class RecursiveAndExtension
{
    private static void Main(string[] args)
    {
        // Recursive Method (Öz Yinelemeli Metot)

        // Example-1

        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result = result * 3;
        }
        Console.WriteLine(result);
        Transactions instance = new Transactions();
        Console.WriteLine(instance.Exponent(3, 4));

        // Extension Method (Genişletilmiş Metot)

        // Example-2

        string name = "Şafak Kerem Balcı";
        bool result1 = name.CheckSpaces();
        Console.WriteLine(result1);
        if (result1)
        {
            Console.WriteLine(name.RemoveWhiteSpaces());
        }
        Console.WriteLine(name.MakeUpperCase());
        Console.WriteLine(name.MakeLowerCase());

        // Example-3

        int[] arr = { 9, 3, 6, 2, 1, 5, 0 };

        arr.SortArray();
        arr.PrintArray();

        // Example-4

        int number = 5;
        Console.WriteLine(number.isEvenNumber());

        // Example-5

        Console.WriteLine(name.GetFirstCharacter());
    }
}

public class Transactions
{
    public int Exponent(int number, int exp)
    {
        if (exp < 2)
        {
            return number;
        }
        return Exponent(number, (exp - 1)) * number;
    }

    // Expo(3, 4) 
    // Expo(3, 3) *3;
    // Expo(3, 2) *3*3;
    // Expo(3, 1) *3*3*3;
    // 3*3*3*3 = 3^4;
}
public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] list = param.Split(" ");
        return string.Join("*", list);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void PrintArray(this int[] param)
    {
        foreach (var i in param)
        {
            Console.WriteLine(i);
        }
    }
    public static bool isEvenNumber(this int param)
    {
        return param % 2 == 0;
    }
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }
}