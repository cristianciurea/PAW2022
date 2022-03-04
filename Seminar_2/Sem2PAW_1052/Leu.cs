using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1052
{
    class Leu: Animal
    {
        private char sex;
        private string[] hrana;
        private bool esteAlfa;

        public char Sex { get => sex; set => sex = value; }
        public string[] Hrana { get => hrana; set => hrana = value; }
        public bool EsteAlfa { get => esteAlfa; set => esteAlfa = value; }

        public Leu(): base()
        {
            sex = 'M';
            hrana = new string[1] { "ceva" };
            esteAlfa = true;
        }

        public Leu(int v, string n, float g, char s, string[] h, bool este):
            base(v, n, g)
        {
            sex = s;
            hrana = h;
            esteAlfa = este;
        }

        public override string ToString()
        {
            string rezultat = base.ToString()+" sexul "+sex+" este mascul alfa "+
                esteAlfa+" si a mancat urmatoarele alimente: "+Environment.NewLine;
            if (hrana != null)
            {
                for (int i = 0; i < hrana.Length; i++)
                    rezultat += hrana[i] + ", ";
            }
            else
                rezultat += " si nu a mancat nimic!";
            return rezultat;
        }
    }
}
