// kısa ve uzun kenarı girilen dikdörtgenin alan ve çevresini hesaplama

// int.Parse yazılanı int şekline çevirir.

using System.ComponentModel;

Console.WriteLine("Kısa Kenar: ");
int kisa = int.Parse(Console.ReadLine());

Console.WriteLine("Uzun Kenar: ");
int uzun = int.Parse(Console.ReadLine());

var alan = kisa * uzun;
var cevre = (kisa + uzun)*2;

var str = "Efe Dogan";
var price = 100.5;

// Console.WriteLine("alan: "+ alan +" "+"çevre: "+ cevre);
Console.WriteLine($"alan: {alan} çevre: {cevre}");

