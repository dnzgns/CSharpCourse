using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müşteri
            Individual musteri1 = new Individual();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "12345";
            musteri1.Name = "Deniz";
            musteri1.Surname = "Gunes";
            musteri1.IdNumber = "1234124213";



            //Kurumsal müşteri

            Coorporate musteri2 = new Coorporate();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "13123";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.TaxNumber = "3421321";

            //Gercek-Tuzel olarak 2 tane nesnem var (müşteri çeşidi)
            //birbirine benziyor diye aynı yerde kullanılamazlar
            //farklı müşteri tipleri
            //SOLID yazılım geliştirme prensipleridir

            Customer musteri3 = new Individual(); //customer inheritance olduğu için individual ve coorporate olarak tutabiliyor yani customer class ı hem individual müşterinin hem de coorporate müsterinin referansını tutabiliyor
           
            Customer musteri4 = new Coorporate();  

            CustomerManager customerManager = new CustomerManager(); // base sınıfın onu inherit eden individual ve coorparete müşterinin referansını tutabilmesi böylece Customermanager a tek tip yolluyorum customer olarak ve operasyon çalışıyor
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

            Console.WriteLine("Hello World!");
        }
    }
}
