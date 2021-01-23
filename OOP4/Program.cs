using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IhtiyacCreditManager();  //interface lerde onu implemente eden classın referansını tutabilir
            
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            //yukarıdaki şubedeki adamın ekranında gördüğü açılır kutuda yazan kredi tipleri

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { vehicleCreditManager, ihtiyacKrediManager, mortgageCreditManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);

            //ihtiyacKrediManager.Calculate();
            //vehicleCreditManager.Calculate();
            //mortgageCreditManager.Calculate();

            /*
            IhtiyacCreditManager ihtiyacKrediManager1 = new IhtiyacCreditManager();
            ihtiyacKrediManager1.Calculate();


            VehicleCreditManager vehicleCreditManager1 = new VehicleCreditManager();
            vehicleCreditManager1.Calculate();

            MortgageCreditManager mortgageCreditManager1 = new MortgageCreditManager();
            mortgageCreditManager1.Calculate();
            */
        }
    }
}
