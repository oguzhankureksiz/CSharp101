//Odev1();
//Odev2();
//Odev3();
Odev4();

static void Odev1()
{
    Console.Write("Pozitif bir sayi giriniz = ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    while (sayi < 1)
    {
        Console.Write("Pozitif bir sayi girmediniz. Tekrardan bir sayi giriniz : ");
        sayi = Convert.ToInt32(Console.ReadLine());
    }

    int[] sayilar = new int[sayi];
    Console.WriteLine(sayi + " adet pozitif sayi giriniz.");

    for (int i = 0; i < sayilar.Length; i++)
    {
        Console.Write((i + 1) + " .sayi : ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] % 2 == 0)
            Console.WriteLine(sayilar[i]);
    }
}
static void Odev2()
{
    Console.Write("Pozitif birinci sayiyi giriniz = ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Pozitif ikinci sayiyi giriniz = ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[] sayilar2 = new int[n];
    Console.WriteLine(n + " adet pozitif sayi giriniz.");

    for (int i = 0; i < sayilar2.Length; i++)
    {
        Console.Write((i + 1) + " .sayi : ");
        sayilar2[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < sayilar2.Length; i++)
    {
        if (sayilar2[i] == m || sayilar2[i] % m == 0)
        {
            Console.WriteLine(sayilar2[i]);
        }
    }
}
static void Odev3()
{
    Console.Write("Pozitif bir sayi giriniz = ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(sayi + " adet kelime giriniz.");
    string[] kelimeler = new string[sayi];
    for (int i = 0; i < kelimeler.Length; i++)
    {
        Console.Write((i + 1) + " .kelime : ");
        kelimeler[i] = Convert.ToString(Console.ReadLine());
    }
    Array.Reverse(kelimeler);

    foreach (var kelime in kelimeler)
    { 
        Console.WriteLine(kelime);
    }
}
static void Odev4()
{
    Console.WriteLine("Lütfen bir cümle yaziniz : ");
    string sentence = Console.ReadLine();

    Print(sentence);

    Console.ReadLine();

    static void Print(string sentence)
    {
        int kelimeSayisi = NumberCount(sentence, ' ');
        int harfSayisi = NumberCounts(sentence, char.IsLetter);


        Console.WriteLine($"Total word count: {kelimeSayisi}");
        Console.WriteLine($"Total letter count: {harfSayisi}");
    }

    static int NumberCount(string sentence, char separator)
    {
        string[] parts = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        return parts.Length;
    }

    static int NumberCounts(string metin, Func<char, bool> kriter)
    {
        int sayac = 0;
        foreach (char karakter in metin)
        {
            if (kriter(karakter))
                sayac++;
        }
        return sayac;
    }
}