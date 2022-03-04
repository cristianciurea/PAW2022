using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1059
{
    class Pisica: Animal
    {
        private string rasa;
        private char sex;
        private bool esteHranita;

        public Pisica():base()
        {
            rasa = "maidaneza";
            sex = 'F';
            esteHranita = true;
        }

        public Pisica(int v, string n, float g, string r, char s, bool este):
            base(v, n, g)
        {
            rasa = r;
            sex = s;
            esteHranita = este;
        }

        public string Rasa { get => rasa; set => rasa = value; }
        public char Sex { get => sex; set => sex = value; }
        public bool EsteHranita { get => esteHranita; set => esteHranita = value; }

        public override string ToString()
        {
            return base.ToString()+" si rasa "+rasa+", sexul "+sex+
                " si este hranita "+esteHranita;
        }
    }
}
