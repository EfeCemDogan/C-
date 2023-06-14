// See https://aka.ms/new-console-template for more information

Console.Write("1.sayı: ");
int sayi1 = int.Parse(Console.ReadLine());

Console.Write("2.sayı: ");
int sayi2 = int.Parse(Console.ReadLine());

int toplam = sayi1 + sayi2;
Console.WriteLine($"girilen topllam değer: {toplam}");