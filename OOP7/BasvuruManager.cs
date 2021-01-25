using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7
{
    class BasvuruManager

    {
        public void BasvuruYap(ICreditManager creditManager, ILoggerService logger)
        {
            creditManager.Calculate();
            logger.Log();
        }
       
    }
}
