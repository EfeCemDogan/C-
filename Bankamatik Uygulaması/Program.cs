using System;

namespace BankamatikUygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            string secim = "";
            double bakiye = 0;
            double ekhesap = 1000;
            double ekhesapLimiti = 1000;

            do
            {
                Console.Write("1-Bakiye Görüntüle \n2-Para Yatırma \n3-Para Çek \n4-Çıkış\nSeçiminiz: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("bakiyeniz {0} TL", bakiye);
                        Console.WriteLine("ek hesap bakiyeniz {0} TL", ekhesap);
                        break;
                    case "2":
                        Console.WriteLine("yatırmak istediğiniz miktar: ");
                        double yatirilan = double.Parse(Console.ReadLine());

                        if (ekhesap < ekhesapLimiti)
                        {
                            double ekhesaptankullanilan = ekhesapLimiti - ekhesap;
                            if (yatirilan >= ekhesaptankullanilan)
                            {
                                ekhesap = ekhesapLimiti;
                                bakiye = yatirilan - ekhesaptankullanilan;
                            }
                            else
                            {
                                ekhesap += yatirilan;
                            }
                        }
                        else
                        {
                            bakiye += yatirilan;
                        }
                        break;
                    case "3":
                        Console.Write("çekmek istediğiniz miktar: ");
                        double cekilecekmiktar = double.Parse(Console.ReadLine());
                        if (cekilecekmiktar > bakiye)
                        {
                            double toplam = bakiye + ekhesap;
                            if (toplam >= cekilecekmiktar)
                            {
                                Console.Write("ek hesap kullanılsın mı? (e/h)");
                                string ekhesaptercihi = Console.ReadLine();

                                if (ekhesaptercihi == "e")
                                {
                                    Console.WriteLine("paranızı alabilirsiniz.");
                                    ekhesap -= (cekilecekmiktar - bakiye);
                                    bakiye = 0;
                                }
                                else
                                {
                                    Console.WriteLine("bakiyeniz yetersiz");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("paranızı alabilirsiniz.");
                            bakiye -= cekilecekmiktar;
                        }
                        break;
                    case "4":
                        Console.WriteLine("çıkış");
                        break;
                    default:
                        Console.WriteLine("hatalı seçim");
                        break;
                }
            } while (secim != "4");

            Console.WriteLine("Uygulamadan çıkıldı.");
        }
    }
}
