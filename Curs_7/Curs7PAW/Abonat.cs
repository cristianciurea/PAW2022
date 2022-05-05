﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs7PAW
{
    class Abonat
    {
        private int cod;
        private string nume;

        public Abonat(int c, string n)
        {
            cod = c;
            nume = n;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nume { get => nume; set => nume = value; }

        public override string ToString()
        {
            return "Abonatul " + nume + " are codul " + cod;
        }
    }
}
