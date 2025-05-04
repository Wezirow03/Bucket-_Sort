using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __ogren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "Mergen";
            int yas = 25;
            //  string yaz = $"Merhaba benim ismim {isim} ve {yas} yasimdayim";        $ isaretini koydugunda degiskenleri yazarak onlarin degerini yazabilirsin
            string yaz = $@"Merhaba benim ismim {isim}.
{yas} yasimdayim.                                          
Tanisdigima memnun oldum";                                // $@ kullanarak satirlarida icine alicak sekilde yazdirabilirsin
            Console.WriteLine(yaz);


        }
    }
}
