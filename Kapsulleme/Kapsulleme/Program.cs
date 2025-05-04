using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kapsuleme kapsuleme = new kapsuleme();
            /* string gizli = kapsuleme.name();
              Console.WriteLine(gizli);*/
          kapsuleme.ajan="Selam";

            Console.WriteLine( kapsuleme.ajan);
        }
    }
}
