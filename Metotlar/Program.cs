
int a = 2;
int b = 3;

Console.WriteLine(a+b);

int sonuc = Topla(5, 89);
EkranaYazdir(Convert.ToString(sonuc));

static int Topla(int sayi1, int sayi2)
{
    return sayi1+sayi2;
}

static void EkranaYazdir(string veri)
{
    Console.WriteLine(veri);
}