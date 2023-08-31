using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // //  Uygulama

            // Console.WriteLine("sayı 1: ");
            // int sayi1 = int.Parse(Console.ReadLine());
            
            // Console.WriteLine("sayı 2: ");
            // int sayi2 = int.Parse(Console.ReadLine());

            // var result = (sayi1>sayi2)?"sayı1>sayı2":"sayı2>sayı1";

            // Console.WriteLine(result);



            // string _email = "info@sadkturan.com";
            // string _parola = "12345";

            // Console.Write("email: ");
            // string email = Console.ReadLine();

            // Console.Write("parola: ");
            // string parola = Console.ReadLine();

            // var result = (_email==email) && (_parola==parola);
            // Console.WriteLine("giriş başarılı "+ result);


            // Console.Write("sayı: ");
            // int sayi = int.Parse(Console.ReadLine());

            // var result = (sayi>0) && (sayi%2==0);
            // Console.WriteLine("sayı pozitif çift sayıdır");

            Console.Write("sayı 1:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("sayı 2:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("sayı 3:");
            int c = int.Parse(Console.ReadLine());

            var result = (a>b) && (a>c);
            Console.WriteLine("en büyük sayı a: "+ result);

            result = (b>a) && (b>c);
            Console.WriteLine("en büyük sayı b: "+ result);

            result = (c>a) && (c>b);
            Console.WriteLine("en büyük sayı c: "+ result);

            string result = ((a>b) && (a>c))
                            ?"a en büyük":((b>a) && (b>c))
                            ?"b en büyük":((c>a) && (c>b))
                            ?"c en büyük":"hatalı bilgi";

            Console.WriteLine(result);

        }
    }
}
