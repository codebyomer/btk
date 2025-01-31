namespace u45_banka_uyg;

public class MusteriEklemeEkrani
{ 
    public static void Goster(List<Musteri> liste)
    {
        Console.Clear();
        Console.WriteLine("Eklemek İstediğiniz Müşteri Adı Soyadı");
        string AdSoyad = Console.ReadLine();

        Musteri musteri = new();
        musteri.AdSoyad = AdSoyad;
        musteri.MusteriNo = (int)DateTime.Now.Ticks;//o anki zaman
        
        liste.Add(musteri);
        
        Console.WriteLine("Müşteri eklendi. Devam etmek için bit tuşa bas...");
        Console.ReadKey();//bir tuşa basılana kadar bekle
    }
}
