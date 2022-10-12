internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan bir cümle girmesi istenir.
        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine()!;

        // Sesli harfler char olarak tanıtılır.
        char[] vowels = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü'};
        char[] lastVowels = new char[sentence.Length];

        // Büyük harfler küçültülerek sadece küçük sesli harf kontrolü yapılır.
        string smallSentence = sentence.ToLower();

        // Sesli harfler kontrol edilir ve başka bir diziye aktarılır.
        for (int i = 0; i < smallSentence.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (smallSentence[i] == vowels[j])
                {
                    lastVowels[i] = smallSentence[i];
                }
            }
        }

        // Sesli harfler dizisi sıraya sokulur.
        Array.Sort(lastVowels);

        // Sesli harfler dizisi elemanları son olarak yazıdırılır.
        Console.WriteLine("Vowels in a sentence: ");
        foreach (var vowel in lastVowels)
        {
            Console.Write(vowel);
        }
    }
}