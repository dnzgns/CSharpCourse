using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)  //hepsinin referansını tutabildiği için ICreditManager kullanıyoruz çünkü hangi kredinin geleceğini bilmiyoruz ve başvuruyap ı kredi türü bağımsız yapıyoruz
        {
            //başvuran bilgilerini değerlendirme yaparız


            creditManager.Calculate();
            loggerService.Log();


            /*aşağıdaki gibi yaparsam tüm başvuruları konut kredisi olarak hesaplar
            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();

            mortgageCreditManager.Calculate();*/

        }


        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)     //müşterinin hangi krediyi çekeceğini bilmiyoruz ve müşteriye hangi krediyi çekmek isterse bilgi vermemiz lazım yani genericlist kullanmam lazım aynı veri türünde sınırız veri taşıyabilir
            // tipi icredit manager olan bir liste oluşturdum
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }

    }
}
