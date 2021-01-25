using System;
using System.Collections.Generic;
using System.Text;

namespace OOP8
{
    class Log1 : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Log1");
        }
    }
}
