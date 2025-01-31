//Müşteriler var
//Müşterilere ait hesaplar
//Müşteri eklenebilir
//Müşteriler listelenebilir
//Müşteriye Hesap açılabilir
//Hesaba para yatırılabilir/çekilebilir
//Bir hesaptan baska hesaba havale edilebilir

using u45_banka_uyg;

int secim = 0;
List<Musteri> musteriListesi = new();
do
{
    secim = MenuEkrani.Goster();

    if(secim == 1)
    {
        MusteriEklemeEkrani.Goster(musteriListesi);
    }
    else if(secim == 2)
    {
        MusteriListelemeEkrani.Goster(musteriListesi);
    }
    else
    {
        Console.WriteLine("Hatalı seçim...");
        Console.ReadKey();
    }

} while(secim!=0);

    
