using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12345678";
            Employee employee = new Employee();

            Person person3 = customer;
            customer.FirstName = "Ahmet";


            Console.WriteLine(person3.FirstName);
            //  Console.WriteLine(person2.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            Console.ReadLine();
        }

    }

    //base class = Person
    class Person
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
