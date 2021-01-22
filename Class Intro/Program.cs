using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); //yeni bir kurs değişkeni
            //tanımlıyorum ve değişkenlerini girecegim
            kurs1.Egitmen = "Deniz";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //yeni bir kurs değişkeni
            //tanımlıyorum ve değişkenlerini girecegim
            kurs2.Egitmen = "Kerem";
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); //yeni bir kurs değişkeni
            //tanımlıyorum ve değişkenlerini girecegim
            kurs3.Egitmen = "Berkay";
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            //Icınde kurs nesnesini barındıran bir array tanımladık
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar) //kurs burada takma isim 
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
            


            Console.ReadLine();
        }
    }

    class Kurs   //classı oluşturdum
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

}
