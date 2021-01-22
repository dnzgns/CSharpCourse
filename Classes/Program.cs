using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Deniz";
            customer.LastName = "Gunes";

            Customer customer2 = new Customer()
            {
                Id =2, City ="Istanbul", FirstName ="Yasemin", LastName ="Gunes"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
    //class CustomerManager  //class oluşturdum
    //{
    //    public void Add()  //metod 1
    //    {
    //        Console.WriteLine("Customer Added!");
    //    }

    //    public void Update() //metod 2
    //    {
    //        Console.WriteLine("Customer Updated!");
    //    }
    //}
    //class ProductManager  //class oluşturdum
    //{
    //    public void Add()  //metod 1
    //    {
    //        Console.WriteLine("Product Added!");
    //    }

    //    public void Update() //metod 2
    //    {
    //        Console.WriteLine("Product Updated!");
    //    }
    //}
}   
