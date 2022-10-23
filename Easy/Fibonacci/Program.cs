using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the depth of Fibonacci array: ");
        int n = int.Parse(Console.ReadLine()!);

        fibonacciAverage(n);

    }
    public static void fibonacciAverage(int depth)
    {

        ArrayList fibonacci = new ArrayList();
        double firstNumber = 0;
        double secondNumber = 1;
        double newNumber = 0;
        double total = 0;
        fibonacci.Add(secondNumber);

        for (int i = 1; i < depth; i++)
        {
            newNumber = firstNumber + secondNumber;
            fibonacci.Add(newNumber);
            firstNumber = secondNumber;
            secondNumber = newNumber;
        }

        Console.WriteLine("The first " + depth + " elements of Fibonacci array: ");
        foreach (var item in fibonacci)
        {
            Console.Write(item + " ");
        }

        for (int i = 0; i < fibonacci.Count; i++)
        {
            total += int.Parse(fibonacci[i]!.ToString()!);
        }

        Console.WriteLine("\nSum of these Elements: " + total);
        Console.WriteLine("Average of these Elements: " + (total / depth));

    }
}