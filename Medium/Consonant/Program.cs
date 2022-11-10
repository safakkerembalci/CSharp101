
Console.WriteLine("Enter a sentence: ");
string sentence = Console.ReadLine()!;
string[] words = sentence.Split();
char[] vovels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };

for (int i = 0; i < words.Length; i++)
{
    bool value = false;
    char[] chars = words[i].ToCharArray();

    for (int j = 0; j < chars.Length; j++)
    {
        if (!vovels.Contains(chars[j]) && j != chars.Length - 1 && !vovels.Contains(chars[j + 1]))
        {
            value = true;
            break;
        }
    }
    Console.Write(value + " ");
}



