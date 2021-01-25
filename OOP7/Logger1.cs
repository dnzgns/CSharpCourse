using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7
{
    class Logger1 : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Log1 loglandı");
        }
    }
}
