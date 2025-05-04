using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using staticogren;

namespace @static.ogren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  static1.yazdir(); --------------------> void static kullanim

            /* string ismim = static1.yaz("Aganiyaz"); ---------------> deger donduren ve parametreli static kullanim
               Console.WriteLine(ismim);*/
            static1.calisanID = "1";
            static1.calisanismi = "Emir";
            static1.yas = 21;
            static1.yaz();
        }
    }
}
