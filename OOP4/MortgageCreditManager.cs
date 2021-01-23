using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class MortgageCreditManager : ICreditManager  // normalde hata veriyordu ampulden implement interface dedim
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
