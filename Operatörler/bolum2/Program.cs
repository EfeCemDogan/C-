using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
// Operatörler



            // Uygulama

            int x=2, y=5, z=10;

            // a-) Kullanıcıdan aldığınız 2 sayının çarpımı ile x,y,z toplamının farkı nedir?
                // Console.Write("1.sayı: ");
                // int sayi1 = int.Parse(Console.ReadLine());

                // Console.Write("2.sayı: ");
                // int sayi2 = int.Parse(Console.ReadLine());

                // int sonuc = (sayi1 * sayi2) - (x+y+z);
                // Console.WriteLine("sonuc: "+ sonuc);

           
            // b-) Kullanıcıdan alınan bir sayının tek çift kontrolünü yapınız.
                // Console.Write("sayı: ");
                // int sayi = int.Parse(Console.ReadLine());
                // string sonuc = (sayi % 2)==0?"evet":"hayır";
                // Console.WriteLine($"girilen sayı çift mi: {sonuc}");

            
            // c-) (x,y,z) toplamının mod 3' ü kaçtır?
                // var sonuc = (x+y+z)%3;
                // Console.WriteLine("sonuc: "+ sonuc);


            // d-) y' nin x. kuvvetini hesaplayınız.
            var sonuc = Math.Pow(y,x);
            Console.WriteLine("sonuc: "+ sonuc);

          
           







            // 3- Karşılaştırma Operatörleri (==,!=,<,>,<=,>=,?:)
            
            // 4- Mantıksal Operatörler (&&,||,!)
        }
    }
}
