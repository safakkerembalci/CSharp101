class StaticClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Personal Number: {0}", Personal.PersonalNumber);

        Personal personal1 = new Personal("Ayşe", "Gülsoy", "IK");
        Console.WriteLine("Personal number: {0}", Personal.PersonalNumber);

        Personal personal2 = new Personal("Murat", "Gülsoy", "IK");
        Console.WriteLine("Personal number: {0}", Personal.PersonalNumber);

        Personal personal3 = new Personal("Derya", "Kavdir", "IK");
        Console.WriteLine("Personal number: {0}", Personal.PersonalNumber);

        Console.WriteLine(Transactions.Sum(100, 200));
        Console.WriteLine(Transactions.Min(400, 50));

    }
}

class Personal
{
    private static int personalNumber;
    public static int PersonalNumber { get => personalNumber;} //set => personalNumber = value; }

    private string name;
    private string surname;
    private string department;
    static Personal()
    {
        personalNumber=0; 
    }
    public Personal(string name, string surname, string department)
    {
        this.name = name;
        this.surname = surname;
        this.department = department;
        personalNumber ++;
    }
}

static class Transactions
{
    public static long Sum (int number1, int number2)
    {
        return number1 + number2;
    }

    public static long Min (int number1, int number2)
    {
        return number1 - number2;
    }
}
