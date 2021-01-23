using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticsIntro
{
    class MyList<T> // T verdiğimiz tip e karşılık geliyor
    {
        T[] items; //T tipinde bir array ve direkt class ın içinde metodların değil
        //constructor classı bir yerde newlersem direkt çalışıyor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //T tipinde bir veri
        {
            T[] tempArray = items; // eski verileri kaybetmemek için referansı geçici olarak atadım
            items = new T[items.Length+1]; //new den sonra referenas değiştği için içi boş bir array

            for (int i = 0; i <tempArray.Length; i++) // önceki verileri yeni array e ekliyorum
            {
                items[i] = tempArray[i]; 
            }

            items[items.Length - 1] = item; // eklenecek yeni veriyi de şimdi ekliyorum


        }
    }
}
