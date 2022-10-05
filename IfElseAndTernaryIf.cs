internal class IfElseAndTernaryIf
{
    private static void Main(string[] args)
    {

        // If - Else If 

        int time = DateTime.Now.Hour;
        Console.WriteLine(time);

        if (time >= 6 && time < 12)
        {
            Console.WriteLine("Good morning!");
        }else if (time <= 16) {
            Console.WriteLine("Have a good day!");
        }else if (time < 20) {
            Console.WriteLine("Good evening!");
        }else {
            Console.WriteLine("Good night!");
        }

        // Ternary If

        string result = time<=18 ? "Good day":"Good night";
        result = time >= 6 && time < 12 ? "Good morning!" : time <= 16 ? "Have a good day!" : "Good night!";
        Console.WriteLine(result);

    }
}