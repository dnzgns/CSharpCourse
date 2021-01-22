using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManager_HW
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi!" + customer.Name);
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi!" + customer.Name);
        }


        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi!" + customer.Name);
        }


    }
}
