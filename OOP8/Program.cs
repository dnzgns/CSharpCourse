using System;

namespace OOP8
{
    class Program
    {
        static void Main(string[] args)
        {
            Credit1 credit1 = new Credit1();
            Credit2 credit2 = new Credit2();
            Log1 log1 = new Log1();
            Log2 log2 = new Log2();

            ApplicationManager applicationManager = new ApplicationManager();

            applicationManager.Application(credit1, log1);




        }
    }
}
