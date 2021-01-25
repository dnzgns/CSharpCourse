using System;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {

            CoorparateCustomers musteri1 = new CoorparateCustomers();
            musteri1.TaxNumber = "32131231";

            IndividualCustomers musteri2 = new IndividualCustomers();
            musteri2.Name = "deniz";

            Customer musteri3 = new IndividualCustomers();
            Customer musteri4 = new CoorparateCustomers();



            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
        }
    }
}
