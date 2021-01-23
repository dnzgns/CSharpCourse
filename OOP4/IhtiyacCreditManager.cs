using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class IhtiyacCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
