
Console.Write("How many integers will you enter: ");
int n = int.Parse(Console.ReadLine()!);

int[] numberList = new int[n];

if (n % 2 == 0)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Enter "+ (i + 1) + ". number: ");
        numberList[i] = int.Parse(Console.ReadLine()!);
    }

    for (int i = 0; i < numberList.Length; i += 2)
    {
        if (numberList[i] == numberList[i + 1])
        {
            int total = numberList[i] + numberList[i + 1];
            Console.Write(total*total + " ");
        }
        else
        {
            int total = numberList[i] + numberList[i + 1];
            Console.Write(total + " ");
        }
    }
}
else
{
    Console.WriteLine("Please enter an even number!");
}




