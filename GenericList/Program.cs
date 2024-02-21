// List<T> list;
// System.Collections.Generic
// T -> object türündedir.


List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");


//Count
Console.WriteLine(sayiListesi.Count);
Console.WriteLine(renkListesi.Count);


//Foreach ve List.Foreach ile elemanlara erişim
foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}
    
foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));


//Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");
sayiListesi.RemoveAt(1);
renkListesi.RemoveAt(1);
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));


//Liste içerisinde arama
if (sayiListesi.Contains(34))
{
    Console.WriteLine("10 liste içerisinde bulundu.");
}

//Eleman ile index'e erişme
Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));


//Diziyi list e çevirme
string[] hayvanlar = {"Kedi","Köpek","Kuş" };
List<string> hayvanListesi =  new List<string>(hayvanlar);


//Listeyi nasıl temizleriz?
hayvanListesi.Clear();


//List içerisinde nesne tutmak
List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "Oğuzhan";
kullanici1.Soyisim = "Küreksiz";
kullanici1.Yas = 24;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim = "Burkay";
kullanici2.Soyisim = "Yılmaz";
kullanici2.Yas = 24;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar()
{
    Isim = "Yusuf",
    Soyisim ="Beserek",
    Yas = 24
});

foreach (var kullanici in kullaniciListesi)
{
    Console.WriteLine("Kullanıcı Adı : " + kullanici.Isim);
    Console.WriteLine("Kullanıcı Soyadı : " + kullanici.Soyisim);
    Console.WriteLine("Kullanıcı Yas : " + kullanici.Yas);
}

hayvanListesi.Clear();

public class Kullanicilar
{
    public string Isim { get; set; }
    public string Soyisim { get; set; }
    public int Yas { get; set; }
}