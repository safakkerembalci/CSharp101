internal class MethodOverloading
{
    private static void Main(string[] args)
    {
        // Out Parameters

        string number = "999";
        int outNumber;

        bool result = int.TryParse(number, out outNumber);
        if(result)
        {
            Console.WriteLine("Successful!");
            Console.WriteLine(outNumber);
        }else 
        {
            Console.WriteLine("Unsuccessful!");
        }
        Methods instance = new Methods();
        instance.Sum(4, 5, out int totalResult);
        Console.WriteLine(totalResult);

        // Method Overloading (Aşırı Yükleme)

        int phrase = 666;
        instance.PrintScreen(Convert.ToString(phrase));
        instance.PrintScreen(phrase);
        instance.PrintScreen("Kerem"," Şafak");

        // Method Sign
        // Method Name + Number of Parameter + Parameter
    }
}

class Methods
{
    public void Sum(int a, int b, out int total)
    {
        total = a + b;
    }
    public void PrintScreen(string data)
    {
        Console.WriteLine(data);
    }
    public void PrintScreen(int data)
    {
        Console.WriteLine(data);
    }
    public void PrintScreen(string data1, string data2)
    {
        Console.WriteLine(data1 + data2);
    }
}