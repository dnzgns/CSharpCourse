using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_HW
{
    class Promo1 : IPromotionManager
    {
        public void Delete()
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Add()
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
