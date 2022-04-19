using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44DersArgumanlarinGecisleri
{
    class Program
    {
        //Passing by value
        //Passing by reference
        //Passing by out
        static void Main(string[] args)
        {
            int x;
            int sayi = 5;
            //kupHesapla(sayi);               //Passing by value      *** Gercek sayi degerinde bir degisiklik olmaz sadece metotta olur.
            //kupHesapla(ref sayi);         //Passing by reference  *** Adrese gore degisiklik yapar, gercek sayi degeri de degisir.
            kupHesapla(out x);            //Passing by out        *** Adrese gore degisiklik yapar, gercek sayi degeri de degisir.
        }

        //static void kupHesapla(int sayi)
        //static void kupHesapla(ref int sayi) 
        static void kupHesapla(out int sayi) 
        {
            sayi = 5; //  *** sadece out kulanırken burada deger veriyoruz...

            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);
        }
    }
}
