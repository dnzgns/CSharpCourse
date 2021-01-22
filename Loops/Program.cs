using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
            //string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number>=0);

            //int number = 100;
            //while ( number >=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}

            //for (int i = 100; i >= 0; i-=2)
            //{
            //Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");

            //Console.WriteLine("Now Number is {0}", number);
            //Console.ReadLine();
        }      
    private static bool IsPrimeNumber(int number)
         {
                bool result = true;

                for (int i = 2; i <= number - 1; i++)
                {
                    if (number % i == 0) //sayının i ye bölümünden kalan yani mod u 0 sa
                    {
                        result = false;
                        i = number;
                    }
                }
                return result;
         }
    }

}
