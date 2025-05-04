using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheriatance_miras_alma
{
    internal class hayvan
    {
        public string adi;
        public string rengi;
        public int yasi;


        public void yazdir()
        {
            Console.WriteLine( $"adi:{adi}" );
            Console.WriteLine($"Rengi:{rengi}");
            Console.WriteLine($"yasi:{yasi}");
        }
    }
}
