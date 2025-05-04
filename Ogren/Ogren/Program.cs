using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.adi = ("Ahmet");
            ogrenci1.soyadi = ("Yakubow");
            ogrenci1.yas = (18);
            ogrenci1.sinifi = (11);
            ogrenci1.ogrencihakkindabilgiler();
            Console.ReadLine();

        }
    }
}

