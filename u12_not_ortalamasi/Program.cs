//klavyeden üç sınav notu girilecek
//ortalama hesaplanacak
//koşulumuz <50 ekrana BAŞARISIZ yazacak değilse BAŞARILI yazacak
int a,b,c;
double ort;

Console.WriteLine("Üç sınav notunuzu giriniz:");

a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ilk notunuz: {a} ");


b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ikinci notunuz: {b} ");

c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ücüncü notunuz: {c} ");

ort = (a+b+c) /3.0;// (int + int + int)/double ==> int

if(ort>=50)
{
    Console.WriteLine("ortalamanız: "+ ort + " BAŞARILI");
}
else 
{
    Console.WriteLine("ortalamınız: "+ ort + " BAŞARISIZ");
}

