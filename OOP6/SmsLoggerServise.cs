using System;
using System.Collections.Generic;
using System.Text;

namespace OOP6
{
    class SmsLoggerServise : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("SMS Atıldı");
        }
    }
}
