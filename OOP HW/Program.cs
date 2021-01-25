using System;

namespace OOP_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer1 gamer1 = new Gamer1();
            Gamer2 gamer2 = new Gamer2();
            gamer1.TC = "32312421";
            gamer1.Name = "Ali";
            gamer1.SurName = "Ateş";
            gamer1.Birthday = "11.23.2000";

            gamer2.TC = "45435353453";
            gamer2.Name = "Fatma";
            gamer2.SurName = "Ateş";
            gamer2.Birthday = "13.12.1992";

            Promo1 promo1 = new Promo1();
            Promo2 promo2 = new Promo2();

            SalesManager salesManager = new SalesManager();

            salesManager.Sales(gamer1,promo2);

            //Promo1 promo1 = new Promo1();

            //promo1.Add();

          
        }
    }
}
