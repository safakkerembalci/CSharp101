internal class Methods
{
    private static void Main(string[] args)
    {

    /*erişim_belirteci geri_donus_tipi metot_adi(argüman/parametre)
	{
		komutlar;
	}
    */

    int a = 2;
    int b = 3;
    Console.WriteLine(a+b);

    Methods1 sample = new Methods1();

    int result = Sum(a, b);
    Console.WriteLine(result);
    sample.PrintScreen(Convert.ToString(result));

    int result1 = sample.IncrementAndSum(ref a, ref b);
    Console.WriteLine(result1);
    sample.PrintScreen(Convert.ToString(result1));

    sample.PrintScreen(Convert.ToString(a + b));
    
    }
    static int Sum(int value1, int value2)
    {
        return value1+value2;
    }
}

class Methods1
{
    public void PrintScreen(string data)
    {
        Console.WriteLine(data);
    }

    public int IncrementAndSum(ref int value1, ref int value2)
    {
        value1++;
        value2++;
        return value1+value2;
    }
}