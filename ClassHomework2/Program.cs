using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework2
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager product1 = new ProductManager(); //product manager tipinde ve product 1 adında değişken tanımladım

            product1.Id = 1;
            product1.Category = 1;
            product1.Subcategory = 1;
            product1.Name = "Book1";
            product1.Price = 99;

            ProductManager product2 = new ProductManager();
            product2.Id = 2;
            product2.Category = 2;
            product2.Subcategory = 2;
            product2.Name = "Book2";
            product2.Price = 199;

            ProductManager product3 = new ProductManager();
            product3.Id = 3;
            product3.Category = 3;
            product3.Subcategory = 3;
            product3.Name = "Book3";
            product3.Price = 299;

            ProductManager[] products = new ProductManager[] {product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Category + " " + product.Subcategory+ " " + product.Subcategory + " " + product.Name + " " + product.Price);
                
            }
            Console.ReadLine();

        }
    }

    class ProductManager // kendi verimi yazar gibi (int gibi) bu veri tipinin özelliklerini yazıyorum
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public int Subcategory { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
