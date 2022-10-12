using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[20];
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();
        Console.WriteLine("Enter 10 numbers: ");

        for (int i = 0; i < 10; i++)
        {
            start:
            int number = Convert.ToInt32(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Please enter a number that is positive and greater than 0!!!");
                    goto start;
                }
                else
                {
                    numbers[i] = number;
                }            
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 2)
            {
                int counter = 0;
                for (int j = 2; j < numbers[i]; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        counter++;
                    }
                }

                if (counter != 0)
                {
                    nonPrimeNumbers.Add(numbers[i]);
                }
                else
                {
                    primeNumbers.Add(numbers[i]);
                }
            }
            else if (numbers[i] == 2)
            {
                primeNumbers.Add(numbers[i]);
            }
            else if (numbers[i] == 1)
            {
                nonPrimeNumbers.Add(numbers[i]);
            }
        }

        nonPrimeNumbers.Sort();
        primeNumbers.Sort();
        nonPrimeNumbers.Reverse();
        primeNumbers.Reverse();
        int totalPrime = 0;
        int totalNonPrime = 0;

        for (int k = 0; k < primeNumbers.Count; k++)
        {
            totalPrime += Convert.ToInt32(primeNumbers[k]);
        }
        for (int l = 0; l < nonPrimeNumbers.Count; l++)
        {
            totalNonPrime += Convert.ToInt32(nonPrimeNumbers[l]);
        }

        Console.WriteLine("Prime Numbers: ");
        foreach (var item in primeNumbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nNumber of Elements: " + primeNumbers.Count);
        Console.WriteLine("Total Value of Elements: " + totalPrime);
        Console.WriteLine("Average of Elements: " + totalPrime / primeNumbers.Count);

        Console.WriteLine("\n***********");

        Console.WriteLine("Non Prime Numbers: ");
        foreach (var item in nonPrimeNumbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nNumber of Elements: " + nonPrimeNumbers.Count);
        Console.WriteLine("Total Value of Elements: " + totalNonPrime);
        Console.WriteLine("Average of Elements: " + totalNonPrime / nonPrimeNumbers.Count);

    }
}