using System;
using System.Globalization;
using System.Reflection;

namespace ConsoleApp
{
    // Bir arayüz tanımlama
    public interface ISesCikarabilir
    {
        void SesCikar();       
    }

    // Bir sınıf, belirli bir arayüzü uygulama
    public class Kedi : ISesCikarabilir
    {
        public void SesCikar()
        {
        Console.WriteLine("Miyav!");
        }
    }
   
    class Program
    {
        static void Main()
        {
            Kedi kedi = new Kedi();
            kedi.SesCikar(); // Kedi sınıfının SesCikar metodu çağrılır.
        }
    }
}
