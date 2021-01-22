using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        { // string ise int değer veremezsin
            //string[] students  = new string[3]; //{ "Engin", "Derin", "Salih" }//3 elemanlı bir array
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //string[] students = new string[3] { "Engin", "Derin", "Salih" };


            //string[] students2 = { "Engin", "Derin", "Salih" }; // new []



            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5,3] // 5 satır 3 stun satırlar 0. dimention sutunlar 1. dimention
            {
                { "istanbul","izmit","balikesir" },
                { "ankara","konya","kırıkkale" },
                { "antalya","adana","mersin" },
                { "rize","trabzon","samsun" },
                { "izmir","muğla","manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("********");
            }

            Console.ReadLine();
        }
    }
}
