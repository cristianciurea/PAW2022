﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1052
{
    [Serializable]
    public abstract class Persoana
    {
        protected int cod;
        protected char sex;

        public Persoana()
        {
            cod = 0;
            sex = 'F';
        }

        public Persoana(int c, char s)
        {
            cod = c;
            sex = s;
        }

        public override string ToString()
        {
            return "Persoana cu codul " + cod + " are sexul " + sex;
        }

        public abstract string spuneAnNastere();
    }
}
