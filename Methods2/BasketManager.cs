using System;
using System.Collections.Generic;
using System.Text;

namespace Methods2
{
    class BasketManager
    {

        //naming convention
        public void Add(Product product) //Add metod u için tipi "Product" olan 
            //aşağıda product olarak kullanan bir parametre istiyorum
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Name);
        }
    }
}
