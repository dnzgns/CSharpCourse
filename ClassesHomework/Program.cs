using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Category = "Electronics";
            product1.Name = "TV";
            product1.Price = 3999;
            product1.Stock = 15;

            Product product2 = new Product();
            product2.Category = "Electronics";
            product2.Name = "Oven";
            product2.Price = 1999;
            product2.Stock = 22;

            Product product3 = new Product();
            product3.Category = "Electronics";
            product3.Name = "PC";
            product3.Price = 6999;
            product3.Stock = 32;

            Product product4 = new Product();
            product4.Category = "Electronics";
            product4.Name = "Dishwasher";
            product4.Price = 2999;
            product4.Stock = 8;

            Product[] products = new Product[] { product1, product2, product3, product4, };

            foreach (var product in products)
            {
                Console.WriteLine("Category = " + product.Category + " ," + "Name = " +  product.Name + " ," + "Price = " + product.Price + " ," + "Stock = " + product.Stock);
            }


            Console.ReadLine();
        }
    }

    class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

    }
}
