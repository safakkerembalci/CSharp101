internal class Operators
{
    private static void Main(string[] args)
    {
        // Atama ve İşlemli Atama

        Console.WriteLine("Atama İşlemleri");
        
        int x = 3;
        int y = 3;
        y = y + 2;

        Console.WriteLine(y);
        y += 5;
        Console.WriteLine(y);
        y /= 2;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        // Mantıksal Operatörler (||, &&, !)

        Console.WriteLine("Mantıksal Operatörler");

        bool isSuccessed = true;
        bool isCompleted = false;

        if(isSuccessed && isCompleted)
        Console.WriteLine("Perfect!");

        if(isSuccessed || isCompleted)
        Console.WriteLine("Great!");

        if(isSuccessed && !isCompleted)
        Console.WriteLine("Fine!");

        // İlişkisel Operatörler (<, >, <=, >=, ==, !=)

        Console.WriteLine("İlişkisel Operatörler");

        int a = 3;
        int b = 4;
        bool result = a < b;

        Console.WriteLine(result);
        result = a > b;
        Console.WriteLine(result);
        result = a >= b;
        Console.WriteLine(result);
        result = a <= b;
        Console.WriteLine(result);
        result = a == b;
        Console.WriteLine(result);
        result = a != b;
        Console.WriteLine(result);

        // Aritmetik Operatörler (+, -, /, *)

        Console.WriteLine("Aritmetik Operatörler");

        int number1 = 10;
        int number2 = 5;
        int result1 = number1 / number2;
        Console.WriteLine(result1);
        result1 = number1 * number2;
        Console.WriteLine(result1);
        result1 = number1 + number2;
        Console.WriteLine(result1);
        result1 = number1 - number2;
        Console.WriteLine(result1);
        result1 = ++number1;
        Console.WriteLine(result1);
        result1 = --number2;
        Console.WriteLine(result1);

        // Mod Alma (%)
        int result2 = 20%3;
        Console.WriteLine(result2);



    }
}