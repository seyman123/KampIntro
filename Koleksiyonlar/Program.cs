﻿
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // new'leyince yeni bir adres oluşuyor. İlk diziden tamamen farklı bir dizi.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);//eski adresi tutmadıgı icin böyle bir eleman yok aslında.

            List<string> isimler2 = new List<string>() { "Engim", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}