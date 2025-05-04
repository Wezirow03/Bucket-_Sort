using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticogren
{
    internal class static1
{

        /* public static void yazdir()
         {
             Console.WriteLine("NE YAZALIM");   ------------->   static metod
         }*/
        /* public static string yaz(string a)
          {
              string yaz1 = "Ismim "; ---------------------> paramtreli ve deger donduren static kullanim
              return yaz1 + a;
          }*/
        public static string calisanID;
        public static string calisanismi;
        public static int yas;
        public static int maas;
      static static1()
        {
            maas = 2500;   // -----------> static de gostermek istedigin degisgeni staticle gostermen lazim
        }
        public static1(string alcalisanID, string alcalisanismi, int alyas)
        {
           calisanID = alcalisanID;
            calisanismi = alcalisanismi;
            yas = alyas;
        }
        public static void yaz()
        {
            Console.WriteLine("Isim:"+ calisanismi );
            Console.WriteLine("ID:" + calisanID);
            Console.WriteLine("Yas:" + yas);
            Console.WriteLine("Maas:" + maas);
        }
    }


}
