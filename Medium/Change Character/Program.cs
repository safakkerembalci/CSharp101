
Console.WriteLine("Please enter a sentence: ");
string sentence = Console.ReadLine()!;
string[] words = sentence.Split();

foreach (var chr in words)
{
    char[] chars = chr.ToCharArray();
    char firstChar = chars[0];
    chars[0] = chars[chars.Length - 1];
    chars[chars.Length - 1] = firstChar;

    foreach (var chr1 in chars)
    {
        string newSentence = chr1.ToString();
        Console.Write(newSentence);
    }
    Console.Write(" ");
}


