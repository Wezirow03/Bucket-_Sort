using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kapsulasyon_property
{
    internal class Pasport_nom
    {
        public string Name { get; set; }
        private int Pas_nom;


        public int pasnom
        {
            get
            {
                return Pas_nom;
            }
            set
            { 
            Pas_nom = value;
            }
        }
    }
    }

