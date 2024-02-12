
//Sort - sıralama yapar
int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

Console.WriteLine("****** Sırasız liste *****");
foreach (var item in sayiDizisi)
{
    Console.Write(item + "  ");
}
Console.WriteLine("\n");

Console.WriteLine("****** Sıralı liste *****");
Array.Sort(sayiDizisi);
foreach (var item in sayiDizisi)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");

//Clear
Console.WriteLine("****** Array Clear *****");
// sayiDizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı 0 lar.
Array.Clear(sayiDizisi,2,2);

foreach (var item in sayiDizisi)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");

//Reverse - elemanları tersten yazar
Console.WriteLine("****** Array Reverse *****");
Array.Reverse(sayiDizisi);
foreach (var item in sayiDizisi)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");

//IndexOf - verdiğiniz eleman dizide varsa indexini döner
Console.WriteLine("****** Array IndexOf *****");
Console.Write(Array.IndexOf(sayiDizisi, 23));


Console.WriteLine("\n");


//Resize - yeniden boyutlandırma yapar
Console.WriteLine("****** Array Resize *****");
Array.Resize<int>(ref sayiDizisi, 9);
sayiDizisi[8] = 99;
foreach (var item in sayiDizisi)
{
    Console.Write(item + " ");
}