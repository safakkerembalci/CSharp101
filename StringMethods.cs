internal class StringMethods
{
    private static void Main(string[] args)
    {
        string sentence = "Dersimiz CSharp, Hoşgeldiniz!";
        string sentence1 = "CSharp";

        // Length (Boşluklar dahil tüm karakterlerin sayısını verir.)
        Console.WriteLine(sentence.Length);

        // ToUpper (Tüm harfleri büyütür.)
        Console.WriteLine(sentence.ToUpper());

        // ToLower (Tüm harfleri küçültür.)
        Console.WriteLine(sentence.ToLower());

        // Concat (İki ayrı string ifadesini birleştirir.)
        Console.WriteLine(String.Concat(sentence, " Merhaba!"));

        // CompareTo (İki string ifadesinin karakter sayılarını karşılaştırır.)
        /* İki string ifadesinin karakter sayıları eşit ise 0 döndürür. 1. string ifadesinin karakter sayısı daha fazla ise '1', 2. string ifadesinin karakter sayısı daha fazla ise '-1' döndürür. */
        Console.WriteLine(sentence.CompareTo(sentence1));

        // Compare (İki string ifadesini benzerlik açısından karşılaştırır.)
        Console.WriteLine(String.Compare(sentence, sentence1, true)); // Büyük-küçük harf uyumuna dikkat eder.
        Console.WriteLine(String.Compare(sentence, sentence1, false)); // Büyük-küçük harf uyumuna dikkat etmez.
        Console.WriteLine(String.Compare(sentence, sentence1)); // Büyük-küçük harf uyumuna dikkat etmez. False gibi davranır.

        // Contains (Bir string ifadesini diğerinin içerisinde kapsayıp kapsamadığını kontrol eder.)
        Console.WriteLine(sentence.Contains(sentence1)); // Kapsıyorsa TRUE döner.

        // EndsWith (String ifadenin sonunu kontrol eder.)
        Console.WriteLine(sentence.EndsWith("Hoşgeldiniz!"));

        // StartsWith (String ifadenin başını kontrol eder.)
        Console.WriteLine(sentence.StartsWith("Merhaba!"));

        // IndexOf (Aranan karakteri ilk bulunduğu yerdeki indeksini döner.)
        Console.WriteLine(sentence.IndexOf("CS"));
        Console.WriteLine(sentence.IndexOf("Kerem")); // Hiçbir şey bulamazsa -1 döner.

        //Insert (Girilen indeks numarasından itibaren yeni bir string ifade ekler.)
        Console.WriteLine(sentence.Insert(0, "Merhaba! "));

        // LastIndexOf (Aranan karakteri sondan başlayarak bulur ve o indeksi getirir.)
        Console.WriteLine(sentence.LastIndexOf("i"));

        // Padleft And Padright (String ifadenin sağına ya da soluna istenilen kadar boşluk bırakır.)
        Console.WriteLine(sentence + sentence1.PadLeft(30));
        Console.WriteLine(sentence + sentence1.PadLeft(30, '*'));
        Console.WriteLine(sentence1.PadLeft(15));
        Console.WriteLine(sentence.PadRight(50) + sentence1);
        Console.WriteLine(sentence.PadRight(50, '-') + sentence1);

        // Remove (İstenilen indekslerdeki karakterleri siler.)
        Console.WriteLine(sentence.Remove(10));
        Console.WriteLine(sentence.Remove(4, 4));
        Console.WriteLine(sentence.Remove(0, 1));

        // Replace (İstenilen indeksteki karakterle yeni bir karakteri yer değiştirir.)
        Console.WriteLine(sentence.Replace("CSharp", "C#"));
        Console.WriteLine(sentence.Replace(" ", "*"));

        // Split (String ifadedeki kelimelei diziye çevirir ve istenileni döndürür.)
        Console.WriteLine(sentence.Split(' ')[1]);

        // Substring (İstenilen indeksten itibaren istenilen sayıda karakter olacak şekilde string ifadesini yazdırır.)
        Console.WriteLine(sentence.Substring(4));
        Console.WriteLine(sentence.Substring(4, 6));
    }
}