//klavyeden kilo ve boy bilgisi alınacak
//vücut kitle indeksi hesaplanacak
//vki = kg / m2 ---> kilo / boy karesi
//<18.5 ---> zayıf
//>18.5-25.0 ----> normal
//>25.0-30 ----> kilolu
//>30 ----> aşırı kilolu

Console.WriteLine("Kilonuzu Girin(kg):");
double kilo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Boyunzu Girin(cm):");
double boy = Convert.ToDouble(Console.ReadLine());

//boy /= 100; //bileşik atama oparatörü boy = boy / 100

double boyMetre = boy / 100; //cm---->metreye donustur
double vki = kilo / (boyMetre * boyMetre);

Console.WriteLine($"Vücut Kitle İndeksi = {vki:f2}");

if(vki<18.5)
    Console.WriteLine("Zayıf");
    
else if(vki <25)
    Console.WriteLine("Normal Kilolu");

else if(vki <30)
    Console.WriteLine("Kilolu");

else //30 ve üzeri ise
    Console.WriteLine("Aşırı Kilolu");
    




