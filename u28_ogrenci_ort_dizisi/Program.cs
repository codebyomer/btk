//1.Öğrencinin Adını Gir: Mustafa
//1.Öğrencinin Ortalamasını Gir: 70
//2.Öğrencinin Adını Gir: Ali
//2.Öğrencinin Ortalamasını Gir: 80

//Öğrenci Adı    | Ortalama
//--------------   --------
//Mustafa                70
//Ali                    80

//Sınıf Ortalaması : 75
//En Başarılı Öğrenci : Ali

string[] isimler = new string[3];
double[] ortalamalar = new double[3];   

for(int i = 0; i <isimler.Length; i++)
{
    Console.WriteLine($"{i + 1}.Öğrencinin Adını Girin:");
    isimler[i] = Console.ReadLine();
    Console.WriteLine($"{i + 1}.Öğrencinin Ortalamasını Girin:");
    ortalamalar[i] =Convert.ToDouble(Console.ReadLine());
}

//Ekanda öğrencileri listeler

Console.WriteLine($"{"Öğrenci Adı", -20} | {"Ortalama", 12}");
Console.WriteLine("--------------------------------------------");

for(int i = 0; i < isimler.Length; i++)
{
    Console.WriteLine($"{isimler[i], -20} | {ortalamalar[i], 12}");
}

//sınıf genel ortalamsını hesapla ve yazdır
double toplamOrt = 0;
foreach(var ort in ortalamalar)
{
    toplamOrt += ort;
}

double genelOrt = toplamOrt / ortalamalar.Length;
Console.WriteLine($"Genel Ortalaması: {genelOrt:f2}");

//en yüksek notu ve öğrenciyi bul ve ekrana yazdır
double ebOrt = Double.MinValue;
string enBasariliİsim = "";

for(int i = 0;i< ortalamalar.Length; i++)
{
    if(ortalamalar[i] > ebOrt)
    {
        enBasariliİsim = isimler[i];
        ebOrt = ortalamalar[i];//*******
    }
}
Console.WriteLine($"En Başarılı Öğrenci:{enBasariliİsim}");
