public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string w = Console.ReadLine()!;
        Console.WriteLine("Enter an index value: ");
        int i = int.Parse(Console.ReadLine()!);

        updateWord(w, i);
        
    }
    public static void updateWord(string word, int index)
    {
        if (index > word.Length || index < 0)
        {
            Console.WriteLine(word);
        }
        else
        {
            string updatedWord = word.Remove(index, 1);
            Console.WriteLine(updatedWord);
        }
    }
}