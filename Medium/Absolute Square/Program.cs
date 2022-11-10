
Console.Write("How many numbers will you enter: ");
int n = int.Parse(Console.ReadLine()!);

int[] numberList = new int[n];
int total1 = 0;
int total2 = 0;

for (int i = 0; i < n; i++)
{
    Console.Write("Enter " + (i + 1) + ". number: ");
    numberList[i] = int.Parse(Console.ReadLine()!);
    if (numberList[i] < 67)
    {
        total1 += Math.Abs(67 - numberList[i]);
    }
    else
    {
        total2 += (int)Math.Pow(Math.Abs((numberList[i] - 67)), 2);
    }
}

Console.WriteLine(total1 + " " + total2);
