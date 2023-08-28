// string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};
// int[] numaralar = {5,3,6,1,2};

// isimlerin sıfırıncı elemanına Aliyi atadı
// isimler[0] = "Ali";

// isimlerde Aliyi 0.sıraya atadı.
// isimler.SetValue("Ali",0);

// İsimler sıfırıncı sırayı çağırır
// Console.WriteLine(isimler.GetValue(0));

//Yazdıüın isimin sırasını yazar
// Console.WriteLine(Array.IndexOf(isimler,"Ahmet"));

// Kaç eleman olduğunu yazar
// Console.WriteLine(isimler.Length);



// --------------------------------

// Sıralar 1.2.3.4.5...    a.b.c.d.e...
// Array.Sort(isimler);
// Array.Sort(numaralar);

// Sondan başlar almaya
// Array.Reverse(isimler);
// Array.Reverse(numaralar);

// Yazan elemanları siler
// Array.Clear(isimler,0,2);
// Array.Clear(numaralar,0,2);

// Üstün çalıştırılma kodu
// Console.WriteLine(isimler.GetValue(0));
// Console.WriteLine(numaralar.GetValue(0));


// --------------------------------

string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};

// Sıfırıncı elemanı getirir
// Console.WriteLine(isimler[0]);

// Sondan 4.sırada kini getirir.
// Console.WriteLine(isimler[^4]);

// var result = isimler[1..3];

// foreach  (var isim in result);
// {
//     Console.WriteLine(isim);
// }

// string msg = "Hello There";
// Console.WriteLine(msg[0..5]);