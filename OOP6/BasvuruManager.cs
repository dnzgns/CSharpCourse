using System;
using System.Collections.Generic;
using System.Text;

namespace OOP6
{
    class BasvuruManager
    {
        public void Basvuruyap(ICreditManager creditManager, ILoggerManager loggerManager)
        {

            creditManager.Calculate();
            loggerManager.Log();


        }
    }
}
