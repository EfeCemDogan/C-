// kısa ve uzun kenarı girilen dikdörtgenin alan ve çevresini hesaplama

Console.Write("kısa kenar: ");
int kisa = int.Parse(Console.ReadLine());


Console.Write("uzun kenar: ");
int uzun = int.Parse(Console.ReadLine());

var alan = kisa * uzun;
var cevre = (kisa + uzun) *2;

// var str = "Efe Doğan";
// var price = 100.5;

// Console.WriteLine("alan: "+ alan + " "+ "çevre "+ cevre);
Console.WriteLine($"alan: {alan} çevre: {cevre}");