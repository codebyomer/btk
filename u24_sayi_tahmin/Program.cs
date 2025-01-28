//rastgele bir sayı tutabilme
//döngü içerisinde kullanıcıdan tahmininmi alabilmeli
//bilemediğinde if ile kontrol edip yönlendirme yapmalı
//hakkı bittiğinde döngüden çıkılmalı
//bilirse döngü sona ermeli ve tebrik etmeli
int sayi = new Random().Next(100);
int hak = 5;//5 hakkın var
Console.WriteLine("Tutulan sayi: "+ sayi);
Console.WriteLine("0-100 aralığında rastgele bir sayı tuttum");
do
{
    Console.WriteLine("Tahminin:");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    hak--;//hakkın bir azaldı

    if(hak == 0 && tahmin !=sayi)
    {
        Console.WriteLine("Üzgünüm Bilemediniz.");
        Console.WriteLine($"Tuttuğum sayı: {sayi}");
        break;
    }  
    if(tahmin > sayi)
    {
        Console.WriteLine("Daha Küçük");
    }
    else if(tahmin < sayi)
    {
        Console.WriteLine("Daha Büyük");
    }
    else
    {
        Console.WriteLine("TEBRİKLER BİLDİNİZ!!");
        break;//döngüden çıkar.
    }

} while(true);
