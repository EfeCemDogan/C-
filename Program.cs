using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};
            // int[] numaralar = {5,3,6,1,2};

            // isimler[0] = "Ali";
            // isimler.SetValue("Ali",0);

            // Console.WriteLine(isimler.GetValue(0));
            // Console.WriteLine(Array.IndexOf(isimler,"Çınar"));
            // Console.WriteLine(isimler.Length);
            
            // Array.Sort(isimler);
            // Array.Sort(numaralar);
            
            // Array.Reverse(isimler);
            // Array.Reverse(numaralar);

            // Array.Clear(isimler,0,2);
            // Array.Clear(numaralar,0,2);

            // Console.WriteLine(isimler.GetValue(0));
            // Console.WriteLine(numaralar.GetValue(0));

            string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};
            
            // Console.WriteLine(isimler[0]);
            // Console.WriteLine(isimler[^2]);

            // var result = isimler[1..3];
            // var result = isimler[1..];
            var result = isimler[..3];

            foreach (var isim in result)
            {
                Console.WriteLine(isim);
            }

            string msg = "Hello There";
            Console.WriteLine(msg[0..5]);

        }
    }
}
