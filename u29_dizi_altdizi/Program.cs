int[] sayilar = [5,0,9,12,4,8];

Console.WriteLine(sayilar[2]);//0
Console.WriteLine(sayilar[^3]);//12
Console.WriteLine(sayilar[2..5]);//0,9,12
var yeniDizi = sayilar[2..5];
foreach(var s in yeniDizi)
{
    Console.WriteLine($"{s}, ");
}
var yeniDizi2 = sayilar[^6..];
foreach(var s in yeniDizi2)
{
    Console.WriteLine($"{s}, ");
}

for(int i = 0; i < yeniDizi2.Length; i++)
{
    var s = yeniDizi2[i];
    Console.WriteLine($"{s}, ");
}
