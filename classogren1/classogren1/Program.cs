using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classogren1
{
     class Program
    {
        static void Main(string[] args)
        {
           musderi kim = new musderi();
            // referans
            kim.a = 5;
            kim.b = 6;
            kim.c = 7;
            kim.YAP(); //deger dondurmeyen 
           int cevap= kim.carp(24, 34); // deger dondurdum ve parametreli
            Console.WriteLine("carpim sonucu "+cevap);
        }
    }

}
