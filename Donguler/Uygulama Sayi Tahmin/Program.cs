using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int tutulan = (new Random()).Next(1,100);
                int hak = 5;
                int tur = 0;
                int sayi;

                double sorupuani = 100 / hak;

                while (hak > 0) {
                    tur++;
                    Console.Write($"{tur}.sayı: ");
                    sayi = int.Parse(Console.ReadLine());
                    hak--;

                    if (sayi == tutulan) {
                        double puan = 100 - (sorupuani * (tur -1));
                        Console.WriteLine($"Tebrikler {tur} defada bildiniz.");
                        Console.WriteLine($"Toplam puan: {puan}");
                        break;
                    }
                    else {
                        if (hak == 0)
                            break;

                        if (tutulan > sayi)
                        Console.WriteLine("Yukarı");
                        else 
                        Console.WriteLine("Aşağı");
                    }
                }
                Console.WriteLine("Oyun bitti.");

                Console.Write("Devam etmek istiyor musunuz? (e/h): ");
                string result = Console.ReadLine();

                if (result=="h" || result=="hayır" || result=="H" || result=="Hayır")
                    break;        

            } while (true);
        }
    }
}
