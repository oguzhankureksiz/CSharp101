// While
// 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program

Console.WriteLine("Bir sayı giriniz : ");
int sayi = Convert.ToInt32(Console.ReadLine());

int sayac = 1;
int toplam = 0;
while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;
}
Console.WriteLine("Ortalama : " + toplam / sayi);



// 'a' dan 'z' ye kadar olan tüm harfleri ekrana yazdır.
char ch = 'a';
while (ch <= 'z')
{
    Console.Write(ch + " ");
    ch++;
}




Console.WriteLine("***** Foreach *****");
string[] arabalar = { "Bmw","Ford","Fiesta","Nissan" };

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}