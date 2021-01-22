using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();

            urun1.Id = 1;
            urun1.Name = "Elma";
            urun1.Price = 15;
            urun1.Detail = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Name = "Karpuz";
            urun2.Price = 80;
            urun2.Detail = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { urun1, urun2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Detail);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("---------Metotlar------------");

            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(urun1);
            basketManager.Add(urun1);
            basketManager.Add(urun2);
            basketManager.Add(urun2);
            basketManager.Add(urun1);

        }
    }
}
