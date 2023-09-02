using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatörler

            // 1- Aritmetik Operatörler (+,-,*,/,%,++,--)

            // int a = 10;
            // int b = 20;
            // float val;

            // val = a + b; // 30
            // val = a - b; // -10
            // val = a * b; // 200
            // val = (float)a / (float)b; // 0
            // val = b % a; // 0
            // val = a++;
            // val = ++a;
            // val = a--;
            // val = --a;

            // Console.WriteLine("a: "+ a);
            // Console.WriteLine("value: "+ val);

            // 2- Atama Operatörleri (=,+=,-=,*=,/=,%=)

            // int x=5,y=10,z=20;
            // double val;

            // x += 5; // x = x + 5;
            // x -= 5; // x = x - 5;
            // x *= 5; // x = x * 5;
            // x /= 5; // x = x / 5;
            // x %= 5; // x = x % 5;
            // val = Math.Pow(2,5);
            // val = Math.Sqrt(25);
            // val = Math.Abs(-10);
            // val = Math.Round(4.4);
            // val = Math.Round(4.5);
            // val = Math.Round(4.6);
            // val = Math.Round(5.5);
            // val = Math.Ceiling(5.5);
            // val = Math.Floor(5.5);
            // val = Math.Floor(5.7);

            // Console.WriteLine($"x: {x} y: {y} z: {z}");
            // Console.WriteLine(val);

            // Uygulama
            // int x=2, y=5, z=10;

            // a-) Kullanıcıdan aldığınız 2 sayının çarpımı ile x,y,z toplamının farkı nedir?
            // Console.Write("1.sayı: ");
            // int sayi1 = int.Parse(Console.ReadLine());

            // Console.Write("2.sayı: ");
            // int sayi2 = int.Parse(Console.ReadLine());

            // int sonuc = (sayi1 * sayi2) - (x+y+z);
            // Console.WriteLine("sonuç: "+ sonuc);
           
            // b-) Kullanıcıdan alınan bir sayının tek çift kontrolünü yapınız.
            // Console.Write("sayı: ");
            // int sayi = int.Parse(Console.ReadLine());
            // string sonuc = (sayi % 2)==0?"evet":"hayır";
            // Console.WriteLine($"girilen sayı çift mi: {sonuc}");
            
            // c-) (x,y,z) toplamının mod 3' ü kaçtır?
            // var sonuc = (x+y+z)%3;
            // Console.WriteLine("sonuc: "+ sonuc);

            // d-) y' nin x. kuvvetini hesaplayınız.
            // var sonuc = Math.Pow(y,x);
            // Console.WriteLine("sonuc: "+ sonuc);

            // 3- Karşılaştırma Operatörleri (==,!=,<,>,<=,>=,?:)

            // password,username => database
            // '13456','sadikturan'

            // int a=5,b=5,c=10,d=4;
            // string username = "sadikturan";
            // string password = "1234567";

            // var result = (a == b); // true
            // result = (a == c); // false
            // result = (username == "sdktrn");
            // result = (password == "123456");
            // result = (a != b);
            // result = (a != c);
            // result = (a > c);
            // result = (c > a);
            // result = (a >= b);
            // result = (a <= b);
            
            // string sonuc = (a == b)?"a=b":"a!=b";
            // sonuc = (username == "sadikturan")?
            //             (password == "123456")?"username doğru ve parola doğru":"username doğru ve parola yanlış":
            //             (password == "123456")?"username yanlış ve parola doğru":"username yanlış ve parola yanlış";
           

            // Console.WriteLine(sonuc);
            // Console.WriteLine("result: "+result);

            // 4- Mantıksal Operatörler (&&,||,!)
            // int x = 6;

            // int hak = 0;
            // char devammi='e';
            // and (&&)
            // true && true => true
            // false && true => false
            // false || false => false

            // var result = (x>5) && (x<10); 
            // result = (hak>0) && (devammi=='e');

            // or (||)
            // true || true => true
            // false || true => true
            // false || false => false

            // result = (x > 0) || (x % 2 == 0);

            // not (!)
            // true => false
            // false => true

            // result = !(x>0);

            // x, 5-10 arasında olan bir çift sayı mıdır?
            // result = ((x>5) && (x<10)) && (x%2==0); // (true && true) && true
            // Console.Write(result);

            // Uygulama

            // 1-) Girilen 2 sayıdan hangisi büyüktür?
            // Console.Write("sayı 1: ");
            // int sayi1 = int.Parse(Console.ReadLine());

            // Console.Write("sayı 2: ");
            // int sayi2 = int.Parse(Console.ReadLine());

            // var result = (sayi1>sayi2)?"sayı1>sayı2":"sayı2>sayı1";

            // Console.WriteLine(result);

            // 2-) Parola ve email bilgisini isteyip doğruluğunu kontrol ediniz.

            // string _email = "info@sadikturan.com";
            // string _parola = "12345";

            // Console.Write("email: ");
            // string email =Console.ReadLine();

            // Console.Write("parola: ");
            // string parola =Console.ReadLine();

            // var result = (_email==email) && (_parola==parola);
            // Console.WriteLine("giriş başarılı: "+ result);

            // 3-) Girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.
            
            // Console.Write("sayı: ");
            // int sayi = int.Parse(Console.ReadLine());

            // var result = (sayi>0) && (sayi%2==0);
            // Console.WriteLine("sayı pozitif çift sayıdır: "+ result);

            // 4-) Girilen 3 sayıyı büyüklük olarak karşılaştırınız.
            // Console.Write("sayı 1:");
            // int a = int.Parse(Console.ReadLine());

            // Console.Write("sayı 2:");
            // int b = int.Parse(Console.ReadLine());

            // Console.Write("sayı 3:");
            // int c = int.Parse(Console.ReadLine());

            // var result = (a>b) && (a>c);
            // Console.WriteLine("en büyük sayı a: "+ result);

            // result = (b>a) && (b>c);
            // Console.WriteLine("en büyük sayı b: "+ result);

            // result = (c>a) && (c>b);
            // Console.WriteLine("en büyük sayı c: "+ result);

            // var result = ((a>b) && (a>c))
            //                 ?"a en büyük":((b>a) && (b>c))
            //                 ?"b en büyük":((c>a) && (c>b))
            //                 ?"c en büyük":"hatalı bilgi";

            // Console.WriteLine(result);

            // 5-) Kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp ortalama hesaplayınız.
                // Eğer ortalama 50 ve üstündeyse geçti değilse kaldı yazdırın.
                // a-) Ortamalama 50 olsa bile final notu en az 50 olmalıdır.
            //     // b-) Finalden 70 alındığında ortalamanın önemi olmasın.

            // Console.Write("1.vize: ");
            // int vize1 = int.Parse(Console.ReadLine());

            // Console.Write("2.vize: ");
            // int vize2 = int.Parse(Console.ReadLine());

            // Console.Write("final: ");
            // int final = int.Parse(Console.ReadLine());

            // var ortalama = ((vize1+vize2)/2)*0.6 + (final*0.4);
            // var durum = (ortalama>=50)
            // var durum = (ortalama>=50) && (final>=50);
            // var durum = (ortalama>=50) || (final>=70);

            // Console.WriteLine("ortalama: "+ ortalama);
            // Console.WriteLine(durum?"geçti":"kaldı");

            // 6- Kişinin ad, kilo ve boy bilgilerini alıp kilo indekslerini hesaplayınız.
                // Formül: (Kilo / boy uzunluğunun karesi)
                // Aşağıdaki tabloya göre kişi hangi gruba girmektedir.
                // 0-18.4    => Zayıf 
                // 18.5-24.9 => Normal  
                // 25.0-29.9 => Fazla Kilolu
                // 30.0-34.9 => Şişman (Obez)


            Console.Write("ad: ");
            string ad = Console.ReadLine();

            Console.Write("kilo: ");
            float kilo = float.Parse(Console.ReadLine());

            Console.Write("boy: ");
            float boy = float.Parse(Console.ReadLine());

            float indeks = (kilo) / (boy*boy);

            var zayif = (indeks>=0) && (indeks<=18.4);
            var normal = (indeks>18.4) && (indeks<=24.9);
            var kilolu = (indeks>24.9) && (indeks<=29.9);
            var obez = (indeks>29.9) && (indeks<=34.9);

            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen zayıf: {zayif}");
            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen normal: {normal}");
            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen kilolu: {kilolu}");
            Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen obez: {obez}");
        }
    }
}
