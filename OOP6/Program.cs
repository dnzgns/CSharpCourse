using System;

namespace OOP6
{
    class Program
    {
        static void Main(string[] args)
        {

            Credit1 credit1 = new Credit1();
            Credit2 credit2 = new Credit2();
            Credit3 credit3 = new Credit3();


            DataBaseLoggerService dataBaseLoggerService = new DataBaseLoggerService();
            SmsLoggerServise smsLoggerServise = new SmsLoggerServise();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(credit2, smsLoggerServise);
            
            
            
           
        }
    }
}
