﻿
//Main************************************************************************************
Ogrenci yeniOgrenci = new();//sınıftan yeni bit nesne(örnek) oluşturduk
yeniOgrenci.numara = 10;
yeniOgrenci.ad = "Sinan";

Ogrenci baskaOgrenci = new();//sınıftan başka yeni bir nesne(örnek) oluşturduk
baskaOgrenci.numara = 5;
baskaOgrenci.ad = "Mustafa";

Console.WriteLine($"Yeni Öğrenci Numara:{yeniOgrenci.numara} Ad:{yeniOgrenci.ad}");
Console.WriteLine($"Diğer Öğrenci Numara:{baskaOgrenci.numara} Ad:{baskaOgrenci.ad}");

//****************************************************************************************
class Ogrenci//Sınıfı tanımladık
{
    public int numara;
    public string ad;
}
