using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
                // Console.Write("Başlangıç: ");
                // int baslangic = int.Parse(Console.ReadLine());

                // Console.Write("Bitiş: ");
                // int bitis = int.Parse(Console.ReadLine());

                // Console.Write("Artış miktarı: ");
                // int artis = int.Parse(Console.ReadLine());

                // for (int i = baslangic; i < bitis; i=i+artis)
                // {
                //     Console.WriteLine(i);
                // }
            

                // int[] sayilar = {1,3,5,6,7,23,67,90};

                // for (int i = 0; i < sayilar.Length; i++)
                // {
                //     if (sayilar[i]%3==0) {
                //         Console.WriteLine(sayilar[i]);
                //     }
                // }

                // int toplam=0;
                // for (int i = 0; i < sayilar.Length; i++)
                // {
                //     toplam += sayilar[i];
                // }

                // Console.WriteLine($"Toplam değer: {toplam}");

                // for (int i = 0; i < sayilar.Length; i++)
                // {
                //     if (sayilar[i]%2==1) {
                //         Console.WriteLine(sayilar[i]);
                //     }
                // }


                // string[] arabalar = {"Opel","Mazda","Toyota","Bmw","Mercedes"};

                // for (int i = 0; i < arabalar.Length; i++)
                // {
                //     if (arabalar[i].Length>=5)
                //     Console.WriteLine(arabalar[i]);
                // }



            //while

            // Console.Write("Adet: ");
            // int adet = int.Parse(Console.ReadLine());

            // string[] urunler = new string[adet];

            // int i=0;
            
            // do {
            //     Console.Write("Üürün adı: ");
            //     urunler[i] = Console.ReadLine();
            //     i++;
            // } while (adet!=i);

            // Console.WriteLine("Ürünler yükleniyor...");

            // for (int a = 0; a < urunler.Length; a++)
            // {
            //     Console.WriteLine("Ürün adı: {0}", urunler[a]);
            // }

            // do-while

            // string name = "Efe Doğan";

            // for (int i = 0; i < name.Length; i++)
            // {
            //     if (name[i] == 'D')
            //         break;
            //     Console.WriteLine(name[i]);
            // }

            // Console.WriteLine("döngü dışı");

            // int x = 0;
            // while (x<5)
            // {
            //     x++;
            //     if (x==2)
            //       continue;
            //     Console.WriteLine(x);
                
            // }

            // Console.WriteLine("Döngü Dışı");


            // int x = 1;
            // int toplam = 0;
            // while (x<100) {
            //     x++;
            //     if (x%2==0)
            //         continue;
            //     toplam += x;
            // }

            // Console.WriteLine("toplam değer: "+ toplam);


            Console.WriteLine("Girilen sayı asal sayı mı?");

            Console.Write("Sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            string[] sayilar = new string[sayi];


            //foreach
        }
    }
}
