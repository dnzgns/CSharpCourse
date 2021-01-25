using System;
using System.Collections.Generic;
using System.Text;

namespace OOP8
{
    class ApplicationManager
    {
        public void Application ( ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
    }
}
