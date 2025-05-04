using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class oda
    {
        public int odakapi;
        public int odamasa;
        public int odakisilik;
        public int odaayna;
        
        
        public void yaz()
        {
            Console.WriteLine("odadaki kapilarin sayisi:"+odakapi);
            Console.WriteLine("Odadaki masalarin sayisi"+odamasa);
            Console.WriteLine("oda kac kisilik:"+odakisilik);
            Console.WriteLine("Odadaki aynalarin sayis"+odaayna);
            Console.WriteLine("");

        }

    }

}
