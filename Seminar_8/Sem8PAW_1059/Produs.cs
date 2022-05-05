using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem8PAW_1059
{
    public class Produs
    {
        private int cod;
        private string denumire;
        private float pret;
        private float cantitate;

        public Produs(int c, string d, float p, float cant)
        {
            cod = c;
            denumire = d;
            pret = p;
            cantitate = cant;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public float Pret { get => pret; set => pret = value; }
        public float Cantitate { get => cantitate; set => cantitate = value; }

        public override string ToString()
        {
            return "Produsul " + denumire + " cu codul " + cod +
                " are pretul " + pret +
                " si cantitatea " + cantitate;
        }
    }
}
