using System;
using System.Collections.Generic;
using System.Text;

namespace OOP6
{
    class DataBaseLoggerService : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("Database'e loglandı");
        }
    }
}
