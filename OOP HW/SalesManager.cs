using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_HW
{
    class SalesManager
    {
        public void Sales(GamerManager gamerManager, IPromotionManager promotionManager)
        {

            promotionManager.Add();
            Console.WriteLine("Satış yapıldı : " + gamerManager.Name);
        }
    }
}
