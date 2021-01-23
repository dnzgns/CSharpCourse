using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    interface ICreditManager //eğerki birisi bu interface i kullanırsa creditmanager i inherit edenlerde aşağıdaki methodlar olmak zorunda!......, okunurluğu arttırmak için interfaceler I ile başlar
    {
        void Calculate();
        void BiseyYap();
        //creditmanager bir interface ve onu implemente eden classlar kuralları kendine göre doldurmak zorunda 
        // interface ler genellikle operasyonel methodlarda kullanılıyor
        //
    }
}
