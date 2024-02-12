// Dizi tanımlama

string[] renkler = new string[2];

string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

int[] dizi;
dizi =  new int[5];


// Dizilere değer atama ve erişim
renkler[0] = "Mavi";
Console.WriteLine(hayvanlar[0]);
dizi[3] = 10;

Console.WriteLine(renkler[0]);
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);


//Döngülerle dizi kullanımı
//Klavyeden girilen n tane sayının ortalamasını hesaplayan program.
Console.Write("Dizinin eleman sayısını giriniz : ");
int elemanSayisi = Convert.ToInt32(Console.ReadLine());
int[] sayilar = new int[elemanSayisi];
int toplam = 0;

for(int i = 0;i< sayilar.Length; i++)
{
    Console.Write("Dizinin " + (i+1) + ". elemanını giriniz : ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayilar[i];
}

int sayac = 1;
foreach (var item in sayilar)
{
    Console.WriteLine("Dizinin " + sayac + ".elemanı : " + item);
    sayac++;
}

int ortalama = toplam / sayilar.Length;
Console.WriteLine("Ortalama : " + ortalama);