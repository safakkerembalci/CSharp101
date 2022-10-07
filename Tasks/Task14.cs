internal class Task14
{
    private static void Main(string[] args)
    {

        // Kullanıcıdan bir cümle girilmesi istenir.
        Console.WriteLine("Please, write a sentence: ");
        string sentence = Console.ReadLine()!.Trim();

        Console.WriteLine(sentence.Count());

        // Cümle, kelimelerine ayrılıp dizi haline getirilir.
        string[] sentenceArray = sentence.Split(' ');

        // Dizinin kaç elemanı varsa cümle o kadar kelime içermektedir.
        int totalWord = sentenceArray.Count();
        Console.WriteLine("Total Word: "+totalWord);

        // Dizi içerisinde gezinerek harf sayısı hesaplanır.
        int totalLetter = 0;
        foreach (var i in sentenceArray)
        {
            totalLetter += i.Length;
        }
        Console.WriteLine("Total Letter: "+totalLetter);
    }
}