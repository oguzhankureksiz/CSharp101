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