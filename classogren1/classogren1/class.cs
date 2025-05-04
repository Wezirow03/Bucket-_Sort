using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace classogren1
{
    internal class musderi
    {
        public int a;
        public int b;
        public int c;
        // referans yapmayi ogrenmek icin yaptim

        public void YAP()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c); 
        //parametresiz deger donmeyen
        }
        public int carp (int sayi , int sayi1 )
        {
            int cevap = sayi * sayi1;
          return cevap; // parametreli geriye deger alabildigimiz
          
        }

    }
}
