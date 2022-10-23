using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        string str = Console.ReadLine()!;

        firstChar(str);

    }
    static void firstChar(string sentence)
    {
        string[] arr = sentence.Split();
        for (int i = 0; i < arr.Length; i++)
        {
            string str = arr[i];
            string firstChar = str.Substring(0, 1);
            string restOfWord = str.Remove(0, 1);
            Console.Write(String.Concat(restOfWord, firstChar));
            Console.Write(" ");
        }
    }
}