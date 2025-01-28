//Değişken tanımlama ve veri türleri
int sayi = 155;
var a = 3.14;
string metin= "35";

int b = Convert.ToInt32(metin);//Convert
byte c = (byte)sayi;//casting

//ekrana yazdırma
Console.WriteLine(sayi);
Console.WriteLine(c);
Console.WriteLine("Merhaba Nasılsın?");
string cevap = Console.ReadLine();
Console.WriteLine("Klavyeden bir sayı giriniz:");
int girilenSayi = Convert.ToInt32(Console.ReadLine());
//değerleri birleştirme
Console.WriteLine($"Cevabınız: {cevap} \nGirdiğiniz sayı: {girilenSayi}");
//operatörler
byte d = 4;//0000100

Console.WriteLine((byte)~d);
