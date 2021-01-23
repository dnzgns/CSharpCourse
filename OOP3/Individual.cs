using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class Individual:Customer    //inheritance  customerde olan tüm özellikler individualda da var   indvidual in ebeveyni customer 
    {
        public string IdNumber { get; set; }      
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
