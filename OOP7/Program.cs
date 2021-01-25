using System;

namespace OOP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Credit1 credit1 = new Credit1();

            Credit2 credit2 = new Credit2();

            Logger1 logger1 = new Logger1();
            Logger2 logger2 = new Logger2();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(credit2,logger2);

        }
    }
}
