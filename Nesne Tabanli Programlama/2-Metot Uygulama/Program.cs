using System;
using System.Xml.Serialization;

namespace ConsoleApp
{

    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }

        public void Start() {
            Console.WriteLine($"{this.Marka} {this.Model} araba çalıştırıldı.");
        }

        public void Stop() {
            Console.WriteLine($"{this.Marka} {this.Model} araba durdu.");
        }

        public void yavasla() {
            Console.WriteLine($"{this.Marka} {this.Model} araba yavaşladı.");
        }

        public void hizlanma() {
            Console.WriteLine($"{this.Marka} {this.Model} araba hizlandı.");
        }

        public  void Menu() {
            string komut = "";
            
            do
            {
                Console.WriteLine("1-Start 2-Hızlan 3-Yavaşla 4-Stop Çıkış: ç");
                Console.Write("Seçiminiz: ");
                komut = Console.ReadLine();

                switch (komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.hizlanma();
                        break;
                    case "3":
                        this.yavasla();
                        break;
                    case "4":
                        this.Stop();
                        break;
                    default:
                        Console.WriteLine("uygulamadan çıkıldı.");
                        break;
                }

            } while (komut != "ç");


        }

        class Program
        {
            static void Main(string[] args) {

                var opel = new Araba();
                opel.Marka = "Opel";
                opel.Model = "Astra";
                opel.Renk = "Beyaz";
                opel.Otomatik = true;

                var mazda = new Araba();
                opel.Marka = "Mazda";
                opel.Model = "CX3";
                mazda.Renk = "Kırmızı";
                mazda.Otomatik = false;

                opel.Menu();
            }
        }
    }
}
