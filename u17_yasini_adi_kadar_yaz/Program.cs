//Klavyeden kişinin adı ve yaşı girilecek
//Kişinin adını yaşı defa ekrana yazacak
//for döngüsü kullanın
Console.WriteLine("Adınızı Giriniz:");
string ad = Console.ReadLine();
Console.WriteLine("Yaşınızı Giriniz:");
int yas = Convert.ToInt32(Console.ReadLine());
for(int i = 1 ; i <= yas; i++ )
{
    Console.WriteLine($"{i} - {ad}");
}
