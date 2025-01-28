using System.Data;
int toplam = 0;
for (int i=1; i <= 5 ; i++)
{
    Console.WriteLine($"{i}.Sayıyı Girin:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;//sayi değişkenini toplamın üzerine ekleme
}
//benim elimde 5 sayının toplamı var
double ortalama = toplam / 5.0;
Console.WriteLine("Girilen Sayıların Ortalaması:" + ortalama );
