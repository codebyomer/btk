﻿//ANA PROGRAM
using u42_sinif_metodu;

Konsol kon = new();


kon.Temizle(ConsoleColor.Red);

int s1 = kon.SayiOku("Bir sayı girin:");
int s2 = kon.SayiOku("Başka bir sayı girin:");

kon.YazSatir($"Toplam = {s1 + s2}");