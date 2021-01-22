using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Deniz", LastName = "Gunes", Adress = "Istanbul" });

            Student student = new Student()
            { 
                Id = 2, 
                FirstName = "Yasemin", 
                LastName = "Gunes", 
                Departmant = "Industrial Engineering"
            };
            manager.Add(student);
            Console.ReadLine();
        }
    }
    interface IPerson //soyut nesne
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer:IPerson //somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }

    class Student:IPerson  //somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Id);
        }
    }
}
