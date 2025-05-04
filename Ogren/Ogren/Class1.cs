using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ogren
{
    public class ogrenci
    {
        public string adi;
        public string soyadi;
        public int sinifi;
        public int yas;
        public void ogrencihakkindabilgiler()
        {
            Console.WriteLine("OGRENCININ ADI:" + adi);
            Console.WriteLine("OGRENCININ SOYADI:" + soyadi);
            Console.WriteLine("OGRENCININ SINIFI:" + sinifi);
            Console.WriteLine("OGRENCININ YASI:" + yas);

        } 
    }
   

}
