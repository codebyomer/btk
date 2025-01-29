//klavyeden girilen sayının faktöriyelini hesapla
//5! = 5 * 4 * 3 * 2 * 1
//0! = 1
//negatif sayıların faktöriyelini hesaplamaz


Console.WriteLine("Bir Sayı Girin:");
int sayi = Convert.ToInt32(Console.ReadLine());

if(sayi>=0)
{
    ulong sonuc = 1;//ulong işaretsiz 64bit sayı
    for(int i = sayi; i >= 1; i--)
    {
        sonuc = sonuc * (ulong)i; //sonucun üzerine çarparak ekleyelim
    }
    Console.WriteLine($"{sayi}! = {sonuc}");

}
else
{
    Console.WriteLine("Negatif sayıların faktöriyeli hesaplanmaz!");
}