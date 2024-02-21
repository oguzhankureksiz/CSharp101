using System.Collections;

ArrayList arrayList = new ArrayList();
//arrayList.Add("Ayşe");
//arrayList.Add(2);
//arrayList.Add(true);
//arrayList.Add('A');

//içerisinde verilere erişim
//Console.WriteLine(arrayList[1]);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}


//AddRange
Console.WriteLine("******* Add Range *******");
string[] renkler = { "kirmizi", "sari", "yesil" };
List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
//arrayList.AddRange(renkler);
arrayList.AddRange(sayilar);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}


//Sort
Console.WriteLine("******* Sort *******");
arrayList.Sort();//Compile de hata vermez ama runtime da hata verir. Farklı tipler olduğu için sıkıntı olur.

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}


//BinarySearch -> önce sıralama yapıp ondan sonra binary search yapabiliriz.
Console.WriteLine("******* Binary Search *******");
Console.WriteLine(arrayList.BinarySearch(9));


//Reverse -> ters sıralama yapar.
Console.WriteLine("******* Reverse *******");
arrayList.Reverse();
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}


//Clear -> listeyi temizler.
Console.WriteLine("******* Clear *******");
arrayList.Clear();
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}