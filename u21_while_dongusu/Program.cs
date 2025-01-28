string pinKodu = "1234";
string tahmin = "";
int deneme = 0;//daha hiç denemedin

while(pinKodu!=tahmin)//tahmin edilen doğru ise biter
{
    if(deneme > 0)
    {
        Console.WriteLine("Bilemediniz.Tekrar deneyin.");
    }
    
    Console.WriteLine("Pin Kodunu Giriniz:");
    tahmin = Console.ReadLine();
    deneme++;//denediğin için 1 arttır
}

Console.WriteLine("TEBRİKLER BİLDİNİZ!!");