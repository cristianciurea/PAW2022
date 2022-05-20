using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10PAW_1052
{
    [Serializable]
    class Student
    {
        private int cod;
        private string nume;
        private float medie;

        public Student(int c, string n, float m)
        {
            cod = c;
            nume = n;
            medie = m;
        }

        public override string ToString()
        {
            return "Studentul " + nume + " cu codul " + cod + " are media " + medie;     
        }
    }
}
