﻿using System;

namespace GenericIntroHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Deniz");
                
        }
    }
        class MyList<T>
        {
            T[] items;

            public MyList()
            {
                items = new T[0];
            }

            public void Add(T item)
            {
                T[] tempArray = items;
                items = new T[items.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];

                }

                items[items.Length - 1] = item;

            }
        }
    
}
