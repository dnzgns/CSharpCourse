using System;

namespace CustomerManager_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.Name = "Ali";
            customer1.Surname = "Yılmaz";
            customer1.Income =1000;

            Customer customer2 = new Customer();

            customer2.Id = 2;
            customer2.Name = "Yılmaz";
            customer2.Surname = "Ali";
            customer2.Income =1500;

            Customer customer3 = new Customer();

            customer3.Id = 3;
            customer3.Name = "Mehmet";
            customer3.Surname = "Yılmaz";
            customer3.Income =2000;




            CustomerManager customer = new CustomerManager();
            customer.Add(customer1);
            customer.Delete(customer2);
            customer.List(customer3);


        }
    }
}
