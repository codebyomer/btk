//klavyeden girilen bir metni
//stack kullanarak tersinden yazdırın
//Örnek;
//Bir metin girin: Programlama
//amalgargorP

Console.WriteLine("Bir metin giriniz:");
string metin = Console.ReadLine();

Stack<char> yigin = new ();
//metindeki tüm karakterleri döngü ile dolaş
//ve yigin içerisine ekle
foreach(char c in metin)
{
    yigin.Push(c);
}
//yığındaki her karakteri tantana ekrana yazdır
while(yigin.Count > 0)
{
    char c = yigin.Pop();
    Console.Write(c);
}
