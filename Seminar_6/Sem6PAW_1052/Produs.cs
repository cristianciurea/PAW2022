using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6PAW_1052
{
    public class Produs
    {
        private string denumire;
        private float pret;
        private float cantitate;

        public Produs(string d, float p, float c)
        {
            denumire = d;
            pret = p;
            cantitate = c;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public float Pret { get => pret; set => pret = value; }
        public float Cantitate { get => cantitate; set => cantitate = value; }

        public override string ToString()
        {
            return "Produsul " + denumire + " cu pretul " + pret +
                " are cantitatea " + cantitate;
        }
    }
}
