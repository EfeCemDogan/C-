using System;

namespace ConsoleApp
{

    class product {
        public string name { get; set; }

        public double price { get; set; }

        public string Description { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("adet: ");
            int adet = int.Parse(Console.ReadLine());

            product[] products = new product[adet];

            int i=0;
            product prd;

            do
            {

                prd = new product();

                Console.Write("ürün adı: ");
                prd.name = Console.ReadLine();

                Console.Write("ürün fiyat: ");
                prd.price = double.Parse(Console.ReadLine());

                Console.Write("ürün açıklama: ");
                prd.Description = Console.ReadLine();

                products[i] = prd;
                i++;

            } while (adet>i);

            Console.Write("***************************************");
            
            // for (int a = 0; a < products.Length; a++)
            // {
            //     Console.WriteLine($"ürün adı: {products[a].name} ürün fiyatı: {products[a].price} ürün açıklama: {products[a].Description}");
            // }

            foreach (var urun in products)
            {
                Console.WriteLine ($"ürün adı: {urun.name} ürün fiyatı: {urun.price} ürün açıklaması: {urun.Description}");
            }


        }
    }
}
