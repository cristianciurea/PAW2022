using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1052
{
    class Zebra: Animal
    {
        private int nrDungi;
        private string taraOrigine;

        public Zebra():base()
        {
            nrDungi = 0;
            taraOrigine = "Kenya";
        }

        public Zebra(int v, string n, float g, int nr, string tara):
            base(v, n, g)
        {
            nrDungi = nr;
            taraOrigine = tara;
        }

        public int NrDungi { get => nrDungi; set => nrDungi = value; }
        public string TaraOrigine { get => taraOrigine; set => taraOrigine = value; }

        public override string ToString()
        {
            return base.ToString() + " si are numar dungi "+nrDungi+
                " si este originara din "+taraOrigine;
        }
    }
}
