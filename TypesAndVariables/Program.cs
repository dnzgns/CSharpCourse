using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            int number1 = 2147483647;
            long number2 = -9223372036854775808;
            short number3 = -32768;
            byte number4 = 255;
            //bool condition = true;
            char character = 'A';
            //string city = "Ankara";
            double number5 = 10.4;
            decimal number6 = 10.4m;

            var number7 = 10; //number 7 yi otomatik int tanımladı
            //number7 = 'A'; // A nın karşılığı klavyedeki sayısal A oldu

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
