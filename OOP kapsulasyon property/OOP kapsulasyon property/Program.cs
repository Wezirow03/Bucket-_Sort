using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kapsulasyon_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pasport_nom pasport_Nom = new Pasport_nom();
            pasport_Nom.Name = "Mergen";
            pasport_Nom.pasnom = 123456789;
            Console.WriteLine( $"Ady:{pasport_Nom.Name}");
            Console.WriteLine($"PASPORT SERIA:{pasport_Nom.pasnom}");

        }
    }
}